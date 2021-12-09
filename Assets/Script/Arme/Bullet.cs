using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]

public class Bullet : MonoBehaviour
{
    public PlayerData datap;

    public GameObject hit;

    public Rigidbody2D rb;
    
    //[SerializeField] float speed = 7f;
    //[SerializeField] int bulletDamage = 10;

    void Start()
    {
        rb.gravityScale = 0;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * datap.bulletSpeed;
        //rb.velocity = new Vector2(0, transform.position.x * -speed);    //another way to shoot
    }

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Disque disque = hitInfo.transform.GetComponent<Disque>();
        EnemyFollowPlayer enemyFollowPlayer = hitInfo.transform.GetComponent<EnemyFollowPlayer>();
        BossMovement bossMovement = hitInfo.transform.GetComponent<BossMovement>();
        MageMove mageMove = hitInfo.transform.GetComponent<MageMove>();
        
        if (disque != null)
        {
            disque.TakeDamage(datap.bulletDamage);
            Instantiate(hit, transform.position, Quaternion.identity);
            Destroy(gameObject); 
        }

        if (enemyFollowPlayer != null)
        {
            enemyFollowPlayer.TakeDamage(datap.bulletDamage);
            Instantiate(hit, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if(bossMovement != null)
        {
            bossMovement.TakeDamage(datap.bulletDamage);
            Instantiate(hit, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        if(mageMove != null)
        {           
            mageMove.TakeDamage(datap.bulletDamage);
            Instantiate(hit, transform.position, Quaternion.identity);
            Destroy(gameObject);
            //score.scoreValue += 200;
        }
        if(hitInfo.gameObject.tag == "skybarriere")
        {
            Instantiate(hit, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        if(hitInfo.gameObject.tag == "plateforme")
        {
            Instantiate(hit, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
