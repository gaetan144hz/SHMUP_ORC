using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseInput : MonoBehaviour
{
    private PauseResume pauseResume;

    public GameObject player;

    private void Awake()
    {
        pauseResume = FindObjectOfType<PauseResume>();
    }

    public void OnPause(InputValue value)
    {
        if (value.isPressed)
        {
            pauseResume.pause();
            //player.SetActive(false);
            return;
        }
    }

    public void activePlayer()
    {
        player.SetActive(true);
    }

    public void disablePlayer()
    {
        player.SetActive(false);
    }
}
