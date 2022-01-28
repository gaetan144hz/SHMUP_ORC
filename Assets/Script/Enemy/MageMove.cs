using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageMove : MonoBehaviour
{
    public EnemyData data;

    public HealthBar healthBar;

    public GameObject explosion;

    public int MageScore = 200;

    public float speed = 1.5f;

    public float fireRate = 1f;
    private float nextFireTime;

    public GameObject enemyBullet;
    public GameObject bulletParent;
    //private Transform enemy; //-----------------------------------FAIRE TABLEAU----------------------------------//

    public List<GameObject> enemyList;

    void Start()
    {
        healthBar.SetMaxHealth(data.currentHealth);
        //enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (EnemyFollowPlayer enemy in EnemyFollowPlayer.GetEnemyList())
        {
            float distanceFromPlayer = Vector2.Distance(enemy.transform.position, transform.position);
            if (distanceFromPlayer < data.range && distanceFromPlayer > data.shootingRange)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, enemy.transform.position, speed * Time.deltaTime);
            }
            else if (distanceFromPlayer <= data.shootingRange && nextFireTime < Time.time)
            {
                Instantiate(enemyBullet, bulletParent.transform.position, Quaternion.identity);
                nextFireTime = Time.time + fireRate;
            }
        }
            // faut le mettre ou ce truc ???  :  && enemyFollowPlayer.data.health < 100

            //int randEnemy = Random.Range(0, enemy.Length); 
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, data.range);
        Gizmos.DrawWireSphere(transform.position, data.shootingRange);
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
