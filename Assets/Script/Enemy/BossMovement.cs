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
    [SerializeField] private float nextFireTime;

    private BossSpawner bossSpawner;
    private RandomSpawner randomSpawner;

    private float lastShot;
    
    public List<GameObject> playerList;

    // Start is called before the first frame update
    void Start()
    {
        randomSpawner = FindObjectOfType<RandomSpawner>();
        bossSpawner = FindObjectOfType<BossSpawner>();
        data = Instantiate(data);
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
            else if (distanceFromPlayer <= data.shootingRange && nextFireTime < Time.time)
            {
                shoot(bullet[0], firePoint[0], 1);
                nextFireTime = Time.time + data.fireRate;
                shoot(bullet[1], firePoint[1], 1);
                nextFireTime = Time.time + data.fireRate;
                shoot(bullet[0], firePoint[3], 1);
                nextFireTime = Time.time + data.fireRate;
                shoot(bullet[2], firePoint[2], 1);
                nextFireTime = Time.time + data.fireRate;
            }
            
        }
    }

    public void shoot(GameObject bullet, Transform firePoint, float cooldown)
    {
        if (Time.time <= lastShot + cooldown)
        {
            Instantiate(bullet, firePoint.transform.position, firePoint.rotation);
        }
        lastShot = Time.time;
        
        Debug.Log(bullet);
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
        randomSpawner.lateGameInstantiate();
        bossSpawner.bossSpawned = false;
        Destroy(GetComponent<BossMovement>());
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }
}
