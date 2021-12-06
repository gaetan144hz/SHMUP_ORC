using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class EnemyFollowPlayer : MonoBehaviour
{
    public EnemyData data;

    public GameObject explosion;

    public int EnemyScore = 100;

    private float nextFireTime;

    [SerializeField] float fireRate = 1f;
    [SerializeField] int damage = 10;
    public GameObject enemyBullet;
    public GameObject bulletParent;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if (distanceFromPlayer < data.range && distanceFromPlayer > data.shootingRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, data.speed * Time.deltaTime);
        }
        else if (distanceFromPlayer <= data.shootingRange && nextFireTime < Time.time)
        {
            Instantiate(enemyBullet,bulletParent.transform.position, Quaternion.identity);
            nextFireTime = Time.time + fireRate;
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
                playerHealth.TakeDamage(damage);
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
    }

    void Die()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}