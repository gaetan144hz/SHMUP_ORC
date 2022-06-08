using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Disque : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] int disqueHealth;

    [Header("Speed")]
    [SerializeField] float speed;

    [Header("Damage")]
    [SerializeField] int damage;
    [SerializeField] int damage2 = 50;

    [Header("Audio")]
    public AudioClip[] sound;
    public AudioSource source;
    
    public Transform blade;

    private Rigidbody2D rb;

    public Vector3 direction;

    Vector3 lastVelocity;

    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();

        var num = Random.Range(1, 10);
        Vector3 moveDir = new Vector3(num, num).normalized;
        rb.velocity = moveDir * speed;
    }

    void Update()
    {
        lastVelocity = rb.velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                CameraShake.Instance.shakeCamera(2.5f, 0.1f);
                playerHealth.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
        
        if (collision.gameObject.CompareTag("skybarriere")) //&& collision.gameObject.CompareTag("Disque")
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);
            TakeDamage(damage2);
        }

        if (collision.gameObject.CompareTag("plateforme"))
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);
            TakeDamage(damage2);
        }

        if (collision.gameObject.CompareTag("Disque"))
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);
        }
        /*
        if (collision.gameObject.CompareTag("Enemy"))
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);
        }
        */
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            Destroy(this.gameObject);
        }
    }

    public void TakeDamage(int playerDamage)
    {
        disqueHealth -= playerDamage;
        if (disqueHealth <= 0)
        {            
            Die();
        }
    }

    void Die()
    {
        Destroy(this.gameObject);
    }
}
