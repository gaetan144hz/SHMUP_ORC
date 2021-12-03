using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    
    [SerializeField] float speed = 7f;
    [SerializeField] int bulletDamage = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb.gravityScale = 0;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        //rb.velocity = new Vector2(0, transform.position.x * -speed);    //another way to shoot
    }
 
    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Disque disque = hitInfo.transform.GetComponent<Disque>();
        EnemyFollowPlayer enemyFollowPlayer = hitInfo.transform.GetComponent<EnemyFollowPlayer>();
        BossMovement bossMovement = hitInfo.transform.GetComponent<BossMovement>(); 
        
        if (disque != null)
        {
            disque.TakeDamage(bulletDamage);
            Destroy(gameObject);
        }

        if (enemyFollowPlayer != null)
        {
            enemyFollowPlayer.TakeDamage(bulletDamage);
            Destroy(gameObject);
        }

        if(bossMovement != null)
        {
            bossMovement.TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
    }
}
