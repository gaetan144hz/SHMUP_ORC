using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageMove : MonoBehaviour
{
    public EnemyData data;

    public float speed = 1.5f;

    public float fireRate = 1f;
    private float nextFireTime;

    public GameObject enemyBullet;
    public GameObject bulletParent;
    private Transform enemy; //-----------------------------------FAIRE TABLEAU----------------------------------//
    
    EnemyFollowPlayer enemyFollowPlayer;
    PlayerHealth playerScript;

    Coroutine coroutineCorpsDamage;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // faut le mettre ou ce truc ???  :  && enemyFollowPlayer.data.health < 100

        float distanceFromPlayer = Vector2.Distance(enemy.position, transform.position);
        if (distanceFromPlayer < data.range && distanceFromPlayer > data.shootingRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, enemy.position, speed * Time.deltaTime);
        }
        else if (distanceFromPlayer <= data.shootingRange && nextFireTime < Time.time)
        {
            if (enemyFollowPlayer.data.currentHealth < 100) 
            {
                Instantiate(enemyBullet, bulletParent.transform.position, Quaternion.identity);
                nextFireTime = Time.time + fireRate;
            }
        }
        
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
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
