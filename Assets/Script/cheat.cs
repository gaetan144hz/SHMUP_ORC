using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class cheat : MonoBehaviour
{
    public PlayerData data;
    private PlayerHealth player;

    private void Awake()
    {
        //data = Instantiate(data);
        player = FindObjectOfType<PlayerHealth>();
    }

    public void OnEnableCheatDamage(InputValue value)
    {
        if (value.isPressed) //press F1
        {
            data.bulletDamage = 9999;
            Debug.Log("BulletDamage at 9999");
            return;
        }
    }

    public void OnDisableCheatDamage(InputValue value)
    {
        if (value.isPressed) //press F2
        {
            data.bulletDamage = 15;
            Debug.Log("BulletDamage at 15");
            return;
        }
    }

    public void OnRemoveHealth(InputValue value)
    {
        if (value.isPressed) //Press F4
        {
            data.currentHealth = 1;
            Debug.Log("Health at 1");
            return;
        }
    }

    public void OnMaxHealth(InputValue value)
    {
        if (value.isPressed) //Press F3
        {
            data.currentHealth = 9999;
            Debug.Log("Healt at 9999");
            return;
        }
    }

    public void OnTimeScale1(InputValue value)
    {
        if (value.isPressed) //press PavNum-
        {
            Time.timeScale = 1f;
            Debug.Log("TimeScale at 1");
            return;
        }
    }

    public void OnTimeScale0(InputValue value)
    {
        if (value.isPressed) //press PavNum+
        {
            Time.timeScale = 0f;
            Debug.Log("TimeScale at 0");
            return;
        }
    }
}
