using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private ScoreSetup scoreSetup;

    [Header("Data")]
    public EnemyData enData;

    [SerializeField] private int bulletDamage;

    [Header("FX")]
    public GameObject hitPrefab;
    public GameObject lastHit;

    [Header("RigidBody")]
    public Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * enData.bulletSpeed;
    }

    void Update()
    {
        
    }
    
    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth playerHealth = hitInfo.transform.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(bulletDamage);
            CameraShake.Instance.shakeCamera(0.7f, 0.1f);
            //StartCoroutine(rumble());
            hitSpawn();
            Destroy(gameObject);
        }
        if (hitInfo.gameObject.tag == "skybarriere")
        {
            hitSpawn();
            Destroy(this.gameObject);
        }
        if (hitInfo.gameObject.tag == "plateforme")
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
