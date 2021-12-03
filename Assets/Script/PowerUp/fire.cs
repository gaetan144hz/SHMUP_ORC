using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
   
    [SerializeField] int increase = 1;

    PlayerHealth playerScript;

    Coroutine coroutineFire;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        playerScript = player.GetComponent<PlayerHealth>();

        if (collision.tag == "Player")
        {
            coroutineFire = StartCoroutine(MakeFire());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StopCoroutine(coroutineFire);
    }

    IEnumerator MakeFire()
    {
        while (true)
        {
            playerScript.playerHealth -= increase;
            yield return new WaitForSeconds(1);
        }
    }

}
