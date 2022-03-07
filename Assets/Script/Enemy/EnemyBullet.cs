using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class EnemyBullet : MonoBehaviour
{
    [Header("Data")]
    public EnemyData data;

    [Header("FX")]
    public GameObject hitPrefab;
    public GameObject lastHit;

    [Header("Target")]
    GameObject target;

    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 movedir = (target.transform.position - transform.position).normalized * data.bulletSpeed;
        rb.velocity = new Vector2(movedir.x, movedir.y);

        Destroy(this.gameObject, 5);
    }

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth playerHealth = hitInfo.transform.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(data.bulletDamage);
            hitSpawn();
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.tag == "skybarriere")
        {
            hitSpawn();
            Destroy(this.gameObject);
        }
        if (hitInfo.gameObject.tag == "plateforme")
        {
            hitSpawn();
            Destroy(this.gameObject);
        }
    }

    public void hitSpawn()
    {
        lastHit = Instantiate(hitPrefab, transform.position, Quaternion.identity);
        Destroy(lastHit, 1f);
    }
}