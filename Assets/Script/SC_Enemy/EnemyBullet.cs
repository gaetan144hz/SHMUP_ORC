using System;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody2D))]

public class EnemyBullet : MonoBehaviour
{
    /*
    private void OnEnable()
    {
        data.OnEnable();
    }
    */

    [Header("Data")]
    public EnemyData data;

    [Header("FX")]
    public GameObject hitPrefab;
    public GameObject lastHit;

    [Header("Target")]
    GameObject target;

    private Rigidbody2D rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();

        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 movedir = (target.transform.position - transform.position).normalized * data.currentBulletSpeed;
        rb.velocity = new Vector2(movedir.x, movedir.y);

        Destroy(this.gameObject, 5);
    }

    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        PlayerHealth playerHealth = hitInfo.transform.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(data.currentBulletDamage);
            CameraShake.Instance.shakeCamera(0.7f, 0.1f);
            fxHit();
            Destroy(this.gameObject);
        }
        if (hitInfo.gameObject.tag == "skybarriere")
        {
            fxHit();
            Destroy(this.gameObject);
        }
        if (hitInfo.gameObject.tag == "plateforme")
        {
            fxHit();
            Destroy(this.gameObject);
        }
    }

    public void fxHit()
    {
        lastHit = Instantiate(hitPrefab, transform.position, Quaternion.identity);
        Destroy(lastHit, 1f);
    }
}