using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class fire : MonoBehaviour
{
    public PlayerData datap;
    private PlayerHealth playerHealth;

    [SerializeField] private int timeToDestroy;

    [SerializeField] private int multiplicator;

    private Rigidbody2D rb;
    [SerializeField] private float speed;
    private bool isCoroutine;
    private float fireDamage;

    private void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        
        rb = GetComponent<Rigidbody2D>();

        rb.gravityScale = 0;
        rb.velocity = transform.right * speed;

        Destroy(this.gameObject,timeToDestroy);
        isCoroutine = false;
    }

    private void OnTriggerStay2D(Collider2D col)
    {

        if (col.tag == "Player" && isCoroutine == false)
        {
            StartCoroutine(MakeFire());
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            isCoroutine = false;
        }
    }

    public IEnumerator MakeFire()
    {
        isCoroutine = true;
        fireDamage = 1f;
        
        while (isCoroutine == true)
        {
            //var firemultiply = fireIncrease * multiplicator;
            fireDamage++;
            playerHealth.TakeDamage(fireDamage);
            yield return new WaitForSeconds(1);   
        }
    }
}
