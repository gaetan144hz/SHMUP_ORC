using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class fire : MonoBehaviour
{ 
    public PlayerData datap;

    public GameObject target;

    [SerializeField] int increase = 1;

    Coroutine coroutineFire;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        rb.gravityScale = 0;
        Destroy(this.gameObject,10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //GameObject player = collision.gameObject;

        if (collision.tag == "Player")
        {
            coroutineFire = StartCoroutine(MakeFire());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        StopCoroutine(coroutineFire);
    }

    IEnumerator MakeFire()
    {
        while (true)
        {
            datap.currentHealth -= increase++;
            yield return new WaitForSeconds(1);   
        }
    }
}
