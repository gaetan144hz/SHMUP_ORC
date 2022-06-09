using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody2D))]

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
    public GameObject deathSound;

    [Header("Cooldown")] 
    public float Pattern1;
    public float Pattern2;
    public float Pattern3;
    
    [Header("Audio")]
    public AudioClip[] sound;
    public AudioSource source;

    private Transform player;
    
    public GameObject[] bullet;

    public Transform[] firePoint;

    private BossSpawner bossSpawner;
    private RandomSpawner randomSpawner;

    private float lastShot;

    public bool shootStatues;
    
    void Start()
    {
        shootStatues = true;
        
        randomSpawner = FindObjectOfType<RandomSpawner>();
        bossSpawner = FindObjectOfType<BossSpawner>();
        data = Instantiate(data);
        healthBar.SetMaxHealth(data.currentHealth);

        StartCoroutine(pattern1());
        StartCoroutine(pattern2());
        StartCoroutine(pattern3());
    }

    void Update()
    {
        healthBar.SetHealth(data.currentHealth);
    }

    public IEnumerator patternCooldown()
    {
        yield return new WaitForSeconds(5f);
        shootStatues = true;
    }
    
    public IEnumerator pattern1()
    {
        while (true)
        {
            shoot(bullet[0],firePoint[0]);
            shoot(bullet[0],firePoint[1]);
            shoot(bullet[0],firePoint[4]);
            shoot(bullet[0],firePoint[5]);
            shoot(bullet[0],firePoint[6]);
            shoot(bullet[0],firePoint[7]);
            yield return new WaitForSeconds(Pattern1);
        }
    }
    
    public IEnumerator pattern2()
    {
        while (true)
        {
            shoot(bullet[1],firePoint[3]);
            shoot(bullet[1],firePoint[8]);
            shoot(bullet[1],firePoint[9]);
            shoot(bullet[1],firePoint[10]);
            yield return new WaitForSeconds(Pattern2);
        }
    }

    public IEnumerator pattern3()
    {
        while (true)
        {
            source.clip = sound[0];
            source.Play();
            shoot(bullet[2],firePoint[2]);
            yield return new WaitForSeconds(Pattern3);
        }
    }
    
   
    public void shoot(GameObject bullet, Transform firePoint)
    {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
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
                playerHealth.TakeDamage(data.currentBulletDamage);
            }
        }
    }
    
    public void TakeDamage(int playerDamage)
    {
        source.clip = sound[3];
        source.Play();
        data.currentHealth -= playerDamage;
        if (data.currentHealth <= 0)
        {
            Die();  
        }
    }

    void Die()
    {
        source.clip = sound[1];
        source.Play();
        source.clip = sound[2];
        source.Play();
        Instantiate(deathSound, transform.position, Quaternion.identity);
        Instantiate(explosion, transform.position, Quaternion.identity);
        randomSpawner.lateGameInstantiate();
        bossSpawner.bossSpawned = false;
        Destroy(GetComponent<BossMovement>());
        gameOverUI.SetActive(true);
        Time.timeScale = 0;
    }
}
