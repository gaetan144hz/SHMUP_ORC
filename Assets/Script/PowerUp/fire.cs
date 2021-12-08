using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class fire : MonoBehaviour
{
    PlayerData datap;

    public float speed;

    public GameObject target;

    [SerializeField] int increase = 1;

    PlayerHealth playerScript;

    PlayerMovement playerMovement;

    Coroutine coroutineFire;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 movedir = (target.transform.position - transform.position).normalized * speed;
        rb.gravityScale = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;

        if (collision.tag == "Player")
        {
            coroutineFire = StartCoroutine(MakeFire());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StopCoroutine(coroutineFire);
        playerMovement.speed = 8;
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
