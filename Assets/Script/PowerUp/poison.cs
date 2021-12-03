using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poison : MonoBehaviour
{
    [SerializeField] int increase = 10;

    PlayerHealth playerScript;

    Coroutine coroutinePoison ;

    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        playerScript = player.GetComponent<PlayerHealth>();

        if (collision.tag == "Player")
        {
            coroutinePoison = StartCoroutine(MakePoison());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StopCoroutine(coroutinePoison);
    }

    IEnumerator MakePoison()
    {
        while (true)
        {
            playerScript.playerHealth -= increase;
            yield return new WaitForSeconds(2);
        }
    }
   
}
