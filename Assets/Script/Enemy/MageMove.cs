using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageMove : MonoBehaviour
{
    [Header("Data")]
    public EnemyData data;

    [Header("HealthBar")]
    public HealthBar healthBar;

    [Header("FX")]
    public GameObject explosion;

    public int MageScore = 200;

    [Header("FireRate")]
    private float nextFireTime;
    private float nextFireRate;

    [Header("Bullet")]
    public GameObject enemyBullet;

    [Header("FirePoint")]
    public GameObject bulletParent;

    private GameObject[] enemies; //-----------------------------------FAIRE TABLEAU----------------------------------//

    public List<GameObject> enemyList;

    void Start()
    {
        healthBar.SetMaxHealth(data.currentHealth);
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var enemy in enemies) //pour chaque enemy dans la liste enemies
        {
            float distanceFromPlayer = Vector2.Distance(enemy.transform.position, transform.position);
            if (distanceFromPlayer < data.range && distanceFromPlayer > data.shootingRange)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, enemy.transform.position, data.currentSpeedMovement * Time.deltaTime);
            }
            else if (distanceFromPlayer <= data.shootingRange && nextFireTime < Time.time)
            {
                Instantiate(enemyBullet, bulletParent.transform.position, Quaternion.identity);
                nextFireTime = Time.time + nextFireRate;
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
