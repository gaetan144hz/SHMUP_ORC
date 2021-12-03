using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healBullet : MonoBehaviour
{
    public EnemyData data; 

    GameObject target;

    public float speed;
    Rigidbody2D bulletRb;

    // Start is called before the first frame update
    void Start()
    {
        bulletRb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Enemy");
        Vector2 movedir = (target.transform.position - transform.position).normalized * speed;
        bulletRb.velocity = new Vector2(movedir.x, movedir.y);
        Destroy(this.gameObject, 5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            GameObject player = collision.gameObject;
            EnemyFollowPlayer playerScript = player.transform.GetComponent<EnemyFollowPlayer>();

            if (playerScript)
            {
                playerScript.data.health += data.healIncrease;
                Destroy(gameObject);
            }
        }
    }     
}

