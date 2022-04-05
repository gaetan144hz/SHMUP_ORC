using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poison : MonoBehaviour
{
    public PlayerData datap;
    private PlayerHealth playerHealth;

    [SerializeField] private int timeToDestroy;

    [SerializeField] public int poisonIncrease;

    Coroutine coroutinePoison ;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;

        Destroy(this.gameObject,timeToDestroy);
    }

    private void OnTriggerStay2D(Collider2D hit)
    {
        playerHealth = hit.transform.GetComponent<PlayerHealth>();

        if (hit.tag == "Player")
        {
            StartCoroutine(MakePoison());
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
        playerHealth = transform.GetComponent<PlayerHealth>();
        
        while (true)
        {
            datap.currentHealth -= poisonIncrease;
            playerHealth.TakeDamage(poisonIncrease);
            yield return new WaitForSeconds(2);
        }
    }
    
}
