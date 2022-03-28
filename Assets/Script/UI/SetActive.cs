using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject obj;

    private Timer timer;

    private void Start()
    {
        timer = FindObjectOfType<Timer>();
    }

    public void Update()
    {
        active();
    }

    public void active()
    {
        if (timer.currentTime <= 18)
        {
            obj.SetActive(true);
        }
        else
        {
            obj.SetActive(false);
        }
    }
}
