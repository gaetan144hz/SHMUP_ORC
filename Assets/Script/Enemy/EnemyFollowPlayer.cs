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

    //[SerializeField] float fireRate = 1f;
    //[SerializeField] int damage = 10;

    public GameObject enemyBullet;
    public GameObject bulletParent;
    //private Transform player;
    //private GameObject player;

    private Rigidbody2D rb;

    public List<GameObject> playerList;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;

        //player = GameObject.FindGameObjectWithTag("Player").transform;

        //playerList = new List<GameObject>(Resources.LoadAll<GameObject>("Player"));
        //Instantiate(playerList[0], transformPlayer.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        foreach(PlayerMovement player in PlayerMovement.GetPlayerList())
        {
            float distanceFromPlayer = Vector2.Distance(player.transform.position, transform.position);
            if (distanceFromPlayer < data.range && distanceFromPlayer > data.shootingRange)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, data.speed * Time.deltaTime);
            }
            else if (distanceFromPlayer <= data.shootingRange && nextFireTime < Time.time)
            {
                Instantiate(enemyBullet, bulletParent.transform.position, Quaternion.identity);
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
    }

    void Die()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}