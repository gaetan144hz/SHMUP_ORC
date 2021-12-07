using UnityEngine;

public class Disque : MonoBehaviour
{
    public int DisqueScore = 150;

    [SerializeField] int disqueHealth = 50;

    [SerializeField] float speed = 7;

    [SerializeField] int damage = 10;

    public Transform blade;

    private Rigidbody2D rb;

    Vector3 lastVelocity;

    // Start is called before the first frame update
    void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
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
                playerHealth.TakeDamage(damage);
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("skybarriere")) //&& collision.gameObject.CompareTag("Disque")
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);
        }

        else if (collision.gameObject.CompareTag("plateforme"))
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);
        }

        else if (collision.gameObject.CompareTag("Disque"))
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);
        }

        else if (collision.gameObject.CompareTag("Enemy"))
        {
            var speed = lastVelocity.magnitude;
            var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);

            rb.velocity = direction * Mathf.Max(speed, 0f);
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
        Destroy(gameObject);
    }
}
