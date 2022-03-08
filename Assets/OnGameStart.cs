using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGameStart : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        Time.timeScale = 0f;
        player = GameObject.FindWithTag("Player");

        if (player.gameObject.tag == "Player")
        {
            Time.timeScale = 1f;
        }
    }
}
