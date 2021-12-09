using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]

public class healer : MonoBehaviour
{
     public PlayerData datap;

    [SerializeField] int increase = 50;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

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