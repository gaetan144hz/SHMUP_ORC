using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class fire : MonoBehaviour
{
    private PlayerData datap;
    private PlayerHealth playerHealth;

    [SerializeField] private int timeToDestroy;

    [SerializeField] public int fireIncrease;
    private int fireMultiply;
    [SerializeField] private int multiplicator;
    Coroutine coroutineFire;

    private Rigidbody2D rb;
    [SerializeField] private float speed;

    private void Start()
    {
        fireIncrease = fireMultiply;
        
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = 0;
        rb.velocity = transform.right * speed;

        Destroy(this.gameObject,timeToDestroy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerHealth = collision.transform.GetComponent<PlayerHealth>();

        if (collision.tag == "Player")
        {
            coroutineFire = StartCoroutine(MakeFire());           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (coroutineFire != null)
        {
            StopCoroutine(coroutineFire);
        }
    }

    IEnumerator MakeFire()
    {
        while (true)
        {
            //datap.currentHealth -= fireIncrease;
            var firemultiply = fireIncrease * multiplicator;
            playerHealth.TakeDamage(firemultiply);
            yield return new WaitForSeconds(1);   
        }
    }
}
