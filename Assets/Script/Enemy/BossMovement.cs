using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class BossMovement : MonoBehaviour
{
    public EnemyData data;

    public HealthBar healthBar;

    public GameObject explosion;

    public int BossScore = 500;

    private Transform player;
    private float nextFireTime;

    public GameObject enemyBullet;
    public GameObject bulletParent;
    public GameObject bulletParent2;

    public List<GameObject> playerList;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(data.currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (PlayerMovement player in PlayerMovement.GetPlayerList())
        {
            float distanceFromPlayer = Vector2.Distance(player.transform.position, transform.position);
            if (distanceFromPlayer < data.range && distanceFromPlayer > data.shootingRange)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, data.currentSpeedMovement * Time.deltaTime);
            }
            else if (distanceFromPlayer <= data.shootingRange && nextFireTime < Time.time)
            {
                Instantiate(enemyBullet, bulletParent.transform.position, Quaternion.identity);
                Instantiate(enemyBullet, bulletParent2.transform.position, Quaternion.identity);
                nextFireTime = Time.time + data.fireRate;
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, data.range);
        Gizmos.DrawWireSphere(transform.position, data.shootingRange);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = collision.gameObject;
        PlayerHealth playerHealth = collision.transform.GetComponent<PlayerHealth>();

        if (collision.gameObject.tag == "Player")
        {
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(data.bulletDamage);
            }
        }
    }
    public void TakeDamage(int playerDamage)
    {
        data.currentHealth -= playerDamage;
        if (data.currentHealth <= 0)
        {
            Die();
        }
        healthBar.SetHealth(data.currentHealth);
    }

    void Die()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
