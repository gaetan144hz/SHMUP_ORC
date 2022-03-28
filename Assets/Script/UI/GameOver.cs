using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;

    public void gameOverUI()
    {
        gameOver.SetActive(true);
        Time.timeScale = 0f;
    }
}
