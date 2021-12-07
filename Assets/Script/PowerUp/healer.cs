using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]

public class healer : MonoBehaviour
{
    PlayerData datap;

    [SerializeField] int increase = 50;

    private Rigidbody2D rb;

    private void Start()
    {
        rb.gravityScale = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            GameObject player = collision.gameObject;
            PlayerData playerScript = player.transform.GetComponent<PlayerData>();

            if (playerScript)
            {
                datap.currentHealth += increase;
                Destroy(gameObject);
            }
        }
    }
}
