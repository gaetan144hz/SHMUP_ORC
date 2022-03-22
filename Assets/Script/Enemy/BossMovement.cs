using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class BossMovement : MonoBehaviour
{
    

    [Header("EnemyData")]
    public EnemyData data;

    [Header("HealthBar")]
    public HealthBar healthBar;

    [Header("UI")]
    public GameObject gameOverUI;

    [Header("FX")]
    public GameObject explosion;

    private Transform player;
    
    public GameObject[] bullet;

    public Transform[] firePoint;

    [Header("FireRate")]
    public float FireRateBullet;

    private float lastShot;
    
    public List<GameObject> playerList;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.SetMaxHealth(data.currentHealth);
    }

    void Update()
    {
        foreach (PlayerMovement player in PlayerMovement.GetPlayerList())
        {
            float distanceFromPlayer = Vector2.Distance(player.transform.position, transform.position);
            if (distanceFromPlayer < data.range && distanceFromPlayer > data.shootingRange)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, data.currentSpeedMovement * Time.deltaTime);
                
            }
            else if (distanceFromPlayer <= data.shootingRange && FireRateBullet < Time.time)
            {
                shoot(bullet[0], firePoint[0], 1);
                shoot(bullet[0], firePoint[1], 1);
            }
            shoot(bullet[1], firePoint[3], 1);
            shoot(bullet[2], firePoint[2], 3);
        }
        
    }

    public void shoot(GameObject bullet, Transform firePoint, float fireRate)
    {
        if (Time.time <= lastShot + fireRate)
        {
            Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        }
        lastShot = Time.time;
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
        Destroy(GetComponent<BossMovement>());
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }
}
