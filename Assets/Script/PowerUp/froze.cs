using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class froze : MonoBehaviour
{
    [SerializeField] int increase = 3;

    PlayerMovement playerScript;

    Coroutine coroutineFroze;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = collision.gameObject;
        playerScript = player.GetComponent<PlayerMovement>();

        if (collision.tag == "Player")
        {
            coroutineFroze = StartCoroutine(MakeFroze());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        StopCoroutine(coroutineFroze);
        playerScript.speed = 8;
    }

    IEnumerator MakeFroze()
    {
        while (true)
        {
            playerScript.speed /= increase;
            yield return new WaitForSeconds(2);
        }
    }

}
