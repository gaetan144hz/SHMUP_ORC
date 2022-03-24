using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bullet : MonoBehaviour
{
    private ScoreSetup scoreSetup;

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
        scoreSetup = FindObjectOfType<ScoreSetup>();

        Vector3 pos = transform.position;
        rb.gravityScale = 0;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * datap.bulletSpeed;
        //rb.velocity = new Vector2(0, transform.position.x * -speed);    //another way to 

        Destroy(this.gameObject, 3);
    }

    private void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Disque disque = hitInfo.transform.GetComponent<Disque>();
        EnemyFollowPlayer enemy = hitInfo.transform.GetComponent<EnemyFollowPlayer>();
        BossMovement boss = hitInfo.transform.GetComponent<BossMovement>();
        MageMove mage = hitInfo.transform.GetComponent<MageMove>();
        DragonMove dragon = hitInfo.transform.GetComponent<DragonMove>();

        if (disque != null)
        {
            disque.TakeDamage(datap.bulletDamage);
            hitSpawn();
            Destroy(gameObject);
        }

        if (hitInfo.gameObject.tag == "Enemy")
        {
            enemy.TakeDamage(datap.bulletDamage);
            scoreSetup.AddDmgScore(datap.bulletDamage);
            hitSpawn();
            Destroy(gameObject);
        }

        if(hitInfo.gameObject.tag == "Boss")
        {
            boss.TakeDamage(datap.bulletDamage);
            scoreSetup.AddDmgScore(datap.bulletDamage);
            hitSpawn();
            Destroy(gameObject);
        }

        if(hitInfo.gameObject.tag == "Invoked")
        {           
            enemy.TakeDamage(datap.bulletDamage);
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
