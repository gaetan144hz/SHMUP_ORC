using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]

public class slime : MonoBehaviour
{
    public PlayerData datap;

    [SerializeField] int increase = 3;

    Rigidbody2D rb;

    Coroutine coroutineFroze;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(MakeMutant());
        }
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        StopCoroutine(coroutineFroze);
        datap.speed = 8;
    }

    IEnumerator MakeMutant()
    {
        while (true)
        {
            datap.speed /= increase;
            yield return new WaitForSeconds(2);
        }
    }

}
