using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]

public class Bullet : MonoBehaviour
{
    [Header("Data")]
    public PlayerData datap;

    [Header("FX")]
    public GameObject hitPrefab;
    public GameObject lastHit;

    [Header("RigidBody")]
    public Rigidbody2D rb;
    
    //[SerializeField] float speed = 7f;
    //[SerializeField] int bulletDamage = 10;

    void Start()
    {
        Vector3 pos = transform.position;
        rb.gravityScale = 0;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * datap.bulletSpeed;
        //rb.velocity = new Vector2(0, transform.position.x * -speed);    //another way to shoot
    }

    private void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Disque disque = hitInfo.transform.GetComponent<Disque>();
        EnemyFollowPlayer enemyFollowPlayer = hitInfo.transform.GetComponent<EnemyFollowPlayer>();
        BossMovement bossMovement = hitInfo.transform.GetComponent<BossMovement>();
        MageMove mageMove = hitInfo.transform.GetComponent<MageMove>();
        DragonMove dragonMove = hitInfo.transform.GetComponent<DragonMove>();

        if (disque != null)
        {
            disque.TakeDamage(datap.bulletDamage);
            hitSpawn();
            Destroy(gameObject);
        }

        if (enemyFollowPlayer != null)
        {
            enemyFollowPlayer.TakeDamage(datap.bulletDamage);
            hitSpawn();
            Destroy(gameObject);
        }

        if(bossMovement != null)
        {
            bossMovement.TakeDamage(datap.bulletDamage);
            hitSpawn();
            Destroy(gameObject);
        }

        if(mageMove != null)
        {           
            mageMove.TakeDamage(datap.bulletDamage);
            hitSpawn();
            Destroy(gameObject);
            
            //score.scoreValue += 200;
        }

        if (dragonMove != null)
        {
            dragonMove.TakeDamage((datap.bulletDamage));
            hitSpawn();
            Destroy(gameObject);
        }
        
        if(hitInfo.gameObject.tag == "skybarriere")
        {
            hitSpawn();
            Destroy(this.gameObject);
        }
        
        if(hitInfo.gameObject.tag == "plateforme")
        {
            hitSpawn();           
            Destroy(this.gameObject);
        }
    }

    public void hitSpawn()
    {
        lastHit = Instantiate(hitPrefab, transform.position, Quaternion.identity);
        Destroy(lastHit, 1f);
    }
}
