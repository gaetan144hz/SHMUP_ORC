using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class EnemyBullet : MonoBehaviour
{
    EnemyData data;

    GameObject target;

    [SerializeField] float speed = 7f;
    [SerializeField] int bulletDamage = 10;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 movedir = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(movedir.x, movedir.y);

        Destroy(this.gameObject, 5);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth playerHealth = hitInfo.transform.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
    }
}