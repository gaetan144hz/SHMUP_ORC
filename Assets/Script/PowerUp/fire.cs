using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class fire : MonoBehaviour
{
    private PlayerData datap;
    private PlayerHealth playerHealth;

    public GameObject target;

    [SerializeField] public int fireIncrease;
    [SerializeField] private int multiplicator;
    Coroutine coroutineFire;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        target = GameObject.FindGameObjectWithTag("Player");

        rb.gravityScale = 0;

        //Destroy(this.gameObject,10);
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
            playerHealth.TakeDamage(fireIncrease);
            yield return new WaitForSeconds(1);   
        }
    }
}
