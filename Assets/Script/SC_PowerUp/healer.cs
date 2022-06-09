using System;
using UnityEngine;

public class healer : MonoBehaviour
{
    public PlayerData datap;

    [SerializeField] int increase = 50;

    private Rigidbody2D rb;
    private PlayerHealth playerHealth;


    private void Awake()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.StartCoroutine(playerHealth.Heal(increase));
            Destroy(this.gameObject,0.1f);
        }
    }
}
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            datap.currentHealth += increase;
            Destroy(gameObject);           
        }
    }
}

/*
            GameObject player = collision.gameObject;
            PlayerData playerScript = player.transform.GetComponent<PlayerData>();

            if (playerScript)
            {
                datap.currentHealth += increase;
                Destroy(gameObject);
            }
            */