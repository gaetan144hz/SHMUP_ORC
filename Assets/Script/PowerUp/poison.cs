using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
            Gamepad.current.SetMotorSpeeds(1f,1f);
            StartCoroutine(MakePoison());
        }
    }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(coroutinePoison != null)
        {
            StopCoroutine(coroutinePoison);
            Gamepad.current.SetMotorSpeeds(0f,0f);

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
