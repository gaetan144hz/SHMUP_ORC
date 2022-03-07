using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{
    [SerializeField] private int spellDamage;

    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        rb.gravityScale = 0;
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();

        if(playerHealth != null)
        {
            playerHealth.TakeDamage(spellDamage);
            Destroy(this.gameObject);
        }
    }
}
