using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class DragonMove : MonoBehaviour
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


    void Awake()
    {
        data = Instantiate(data);

        rb = GetComponent<Rigidbody2D>();
        scoreSetup = FindObjectOfType<ScoreSetup>();
        healthBar = FindObjectOfType<HealthBar>();

        rb.gravityScale = 0;
        healthBar.SetMaxHealth(data.currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (PlayerMovement player in PlayerMovement.GetPlayerList())
        {
            float distanceFromPlayer = Vector2.Distance(player.transform.position, transform.position);
            
            if (distanceFromPlayer <= data.shootingRange && nextFireTime < Time.time)
            {
                Instantiate(enemyBullet, bulletParent.transform.position, Quaternion.identity);
                nextFireTime = Time.time + data.fireRate;
            }
        }
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