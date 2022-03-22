using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poison : MonoBehaviour
{
    private PlayerData datap;
    private PlayerHealth playerHealth;

    [SerializeField] public int poisonIncrease;

    Coroutine coroutinePoison ;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;

        //Destroy(this.gameObject,10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerHealth = collision.transform.GetComponent<PlayerHealth>();

        if (collision.tag == "Player")
        {
            coroutinePoison = StartCoroutine(MakePoison());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(coroutinePoison != null)
        {
            StopCoroutine(coroutinePoison);
        } 
    }

    IEnumerator MakePoison()
    {
        while (true)
        {
            datap.currentHealth -= poisonIncrease;
            playerHealth.TakeDamage(poisonIncrease);
            yield return new WaitForSeconds(2);
        }
    }
}
