using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superBullet : MonoBehaviour
{
    PlayerData datap;

    Coroutine superWeapon;

    public int increase;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject player = collision.gameObject;
        //playerScript = player.GetComponent<PlayerHealth>();

        if (collision.gameObject.tag == "Player")
        {
            superWeapon = StartCoroutine(SuperShoot());

        }
    }

    IEnumerator SuperShoot()
    {
        while (true)
        {
            datap.bulletDamage = increase;
            yield return new WaitForSeconds(10);
            datap.bulletDamage = 10;
            StopCoroutine(superWeapon);
        }
    }
}
