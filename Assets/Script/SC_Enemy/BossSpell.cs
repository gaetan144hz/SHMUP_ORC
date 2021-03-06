using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class BossSpell : MonoBehaviour
{
    [Header("Data")]
    public EnemyData data;

    [Header("FX")]
    public GameObject hitPrefab;
    public GameObject lastHit;

    [Header("Target")]
    GameObject target;

    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 movedir = (target.transform.position - transform.position).normalized * data.currentSpellSpeed;
        rb.velocity = new Vector2(movedir.x, movedir.y);
    }

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth playerHealth = hitInfo.transform.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(data.currentSpellDamage);
            CameraShake.Instance.shakeCamera(0.7f, 1f);
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