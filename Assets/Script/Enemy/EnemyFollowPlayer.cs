using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class EnemyFollowPlayer : MonoBehaviour
{
    private ScoreSetup scoreSetup;

    [Header("EnemyData")]
    public EnemyData data;

    [Header("HealthBar")]
    public HealthBar healthBar;

    [Header("FX")]
    public GameObject explosion;

    [Header("FireRate")]
    private float nextFireTime;

    [Header("Bullet")]
    public GameObject enemyBullet;

    [Header("FirePoint")]
    public GameObject bulletParent;

    private Rigidbody2D rb;
    private Vector2 movement;

    public List<GameObject> playerList;

    public static List<EnemyFollowPlayer> enemyList = new List<EnemyFollowPlayer>();
    public static List<EnemyFollowPlayer> GetEnemyList()
    {
        return enemyList;
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        scoreSetup = FindObjectOfType<ScoreSetup>();

        rb.gravityScale = 0;
        healthBar.SetMaxHealth(data.currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        foreach(PlayerMovement player in PlayerMovement.GetPlayerList())
        {
            float distanceFromPlayer = Vector2.Distance(player.transform.position, transform.position);
            if (distanceFromPlayer < data.range && distanceFromPlayer > data.shootingRange)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, data.currentSpeedMovement * Time.deltaTime);
                Vector3 direction = player.transform.position - transform.position;
                movement = direction;
            }
            else if (distanceFromPlayer <= data.shootingRange && nextFireTime < Time.time)
            {
                Instantiate(enemyBullet, bulletParent.transform.position, transform.localRotation);
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
        scoreSetup.AddKillScore(1);
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}