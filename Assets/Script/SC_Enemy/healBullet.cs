using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healBullet : MonoBehaviour
{
    [Header("Data")]
    public EnemyData data;

    [Header("Target")]
    GameObject target;

    [Header("HealPoint")]
    [SerializeField] int healIncrease = 15;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        target = GameObject.FindGameObjectWithTag("Enemy");
        Vector2 movedir = (target.transform.position - transform.position).normalized * data.currentSpeedMovement;
        rb.velocity = new Vector2(-movedir.x, -movedir.y);

        Destroy(this.gameObject, 5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            GameObject enemy = collision.gameObject;
            EnemyFollowPlayer enemyScript = enemy.transform.GetComponent<EnemyFollowPlayer>();

            if (enemyScript)
            {
                enemyScript.data.currentHealth += healIncrease;
                Destroy(gameObject);
            }
        }
    }     
}

