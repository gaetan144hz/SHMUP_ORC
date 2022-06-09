using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseInput : MonoBehaviour
{
    private PauseResume pauseResume;

    public GameObject player;

    private TestSpawnUnitaire testUnitaire;

    private void Awake()
    {
        pauseResume = FindObjectOfType<PauseResume>();
        testUnitaire = FindObjectOfType<TestSpawnUnitaire>();
    }
    
    public void OnDisableSpUI(InputValue value)
    {
        if (value.isPressed)
        {
            testUnitaire.disableSpUI();
        }
    }

    public void OnEnableSpUI(InputValue value)
    {
        if (value.isPressed)
        {
            testUnitaire.enableSpUI();
        }
    }

    public void OnPause(InputValue value)
    {
        if (value.isPressed)
        {
            pauseResume.pause();
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
