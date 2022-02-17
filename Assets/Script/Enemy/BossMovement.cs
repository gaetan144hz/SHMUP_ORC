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
    
    [Header("Bullet")]
    public GameObject enemyBullet;
    public GameObject bossSpellBullet1;
    public GameObject bossSpellBullet2;

    [Header("FireRate")]
    public float spellFireRate;
    public float cooldown;
    public float FireRateSpell2;

    private float lastShot;
    private float nextFireTime;

    [Header("FirePoint")]
    public GameObject bossFirePoint1;
    public GameObject bossFirePoint2;

    public GameObject spellFirePoint1;
    public GameObject spellFirePoint2;

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
                Instantiate(enemyBullet, bossFirePoint1.transform.position, Quaternion.identity);
                Instantiate(enemyBullet, bossFirePoint2.transform.position, Quaternion.identity);
                nextFireTime = Time.time + data.fireRate;
            }
        }

        Invoke("spell2", FireRateSpell2);

        spell1();
    }

    public void spell1()
    {
        if (Time.time - lastShot < cooldown)
        {
            return;
        }
        lastShot = Time.time;
        Instantiate(bossSpellBullet1, spellFirePoint1.transform.position, spellFirePoint1.transform.rotation);
    }

    public void spell2()
    {
        Instantiate(bossSpellBullet2, spellFirePoint2.transform.position, Quaternion.identity);
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
