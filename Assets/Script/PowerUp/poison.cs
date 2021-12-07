using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]

public class poison : MonoBehaviour
{
    PlayerData datap;

    [SerializeField] int increase = 10;

    Coroutine coroutinePoison ;

    private Rigidbody2D rb;

    private void Start()
    {
        rb.gravityScale = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        //playerScript = player.GetComponent<PlayerHealth>();

        if (collision.tag == "Player")
        {
            coroutinePoison = StartCoroutine(MakePoison());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StopCoroutine(coroutinePoison);
    }

    IEnumerator MakePoison()
    {
        while (true)
        {
            datap.currentHealth -= increase;
            yield return new WaitForSeconds(2);
        }
    }
   
}
