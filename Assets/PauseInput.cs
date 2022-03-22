using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseInput : MonoBehaviour
{
    private PauseResume pauseResume;

    private void Awake()
    {
        pauseResume = FindObjectOfType<PauseResume>();
    }

    public void OnResume(InputValue value)
    {
        if (value.isPressed)
        {
            pauseResume.pause();
        }
    }

    public void OnPause(InputValue value)
    {
        if (value.isPressed)
        {
            pauseResume.resume();
        }
    }
}
