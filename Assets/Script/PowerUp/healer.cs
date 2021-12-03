using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healer : MonoBehaviour
{
    [SerializeField] int increase = 50;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") 
        {
            GameObject player = collision.gameObject;
            PlayerHealth playerScript = player.transform.GetComponent<PlayerHealth>();

            if (playerScript)
            {
                playerScript.playerHealth += increase;
                Destroy(gameObject);
            }
        }
    }
}
