using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    public float speed = 10.0f;
    public int health = 100;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    //public GameObject deathEffect;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = transform.right * speed;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.x));
    }

    public void TakeDamage (int playerDamage)
    {
        health -= playerDamage;
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "skybarriere")
        {
            Destroy(gameObject);
            
        }
    }
}
