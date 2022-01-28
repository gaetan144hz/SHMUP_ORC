using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public PlayerData datap;

    [SerializeField] float increase = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameObject player = collision.gameObject;

            if (datap)
            {
                datap.speed += increase;
                Destroy(gameObject);
            }
        }
    }
}
