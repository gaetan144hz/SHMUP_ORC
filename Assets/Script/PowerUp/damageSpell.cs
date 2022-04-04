using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageSpell : MonoBehaviour
{
    public PlayerData datap;

    [SerializeField] int increase = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject player = collision.gameObject;

            if (datap)
            {
                datap.spellDamage += increase;
                Destroy(this.gameObject);
            }
        }
    }
}
