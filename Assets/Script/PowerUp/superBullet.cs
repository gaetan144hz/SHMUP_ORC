using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superBullet : MonoBehaviour
{
    public PlayerData datap;

    [SerializeField] int increase = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject player = collision.gameObject;

            if (datap)
            {
                datap.bulletDamage += increase;
                Destroy(gameObject);
            }
        }
    }
}
