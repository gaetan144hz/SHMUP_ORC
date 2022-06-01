using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speelFireRate : MonoBehaviour
{
    public PlayerData datap;

    [SerializeField] float increase = 0.1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject player = collision.gameObject;

            if (datap)
            {
                datap.currentSpellCooldown -= increase;
                Destroy(this.gameObject);
            }
        }
    }
}
