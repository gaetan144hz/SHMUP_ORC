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

    private bool disqueSpawner;
    public GameObject spawnD;

    private bool powerUp;
    public GameObject spawnP;

    public RandomDisqueSpawner randomDisqueSpawner;

    public TextMeshProUGUI cheatDamage;
    public TextMeshProUGUI cheatHealth;

    private void Awake()
    {
        randomDisqueSpawner = FindObjectOfType<RandomDisqueSpawner>();
        player = FindObjectOfType<PlayerHealth>();
    }

    void Update()
    {
        cheatDamage.text = $"BulletDamage: {data.bulletDamage}";
        cheatHealth.text = $"Health: {data.currentHealth}";
    }

    public void OnEnableDisqueSpwn(bool value)
    {
        if (disqueSpawner == true)
        {
            spawnD.SetActive(value);
        }
        if(disqueSpawner == false)
        {
            randomDisqueSpawner.spawn1();
        }
    }

    public void OnEnablePowerUp(bool value)
    {
        if (powerUp == true)
        {
            spawnP.SetActive(value);
        }

        if (powerUp == false)
        {
            spawnP.SetActive(value);
        }
    }

    public void OnEnableCheatDamage(InputValue value)
    {
        if (value.isPressed) //press O
        {
            data.bulletDamage = 9999;
            Debug.Log("BulletDamage at 9999");
            return;
        }
    }

    public void OnDisableCheatDamage(InputValue value)
    {
        if (value.isPressed) //press P
        {
            data.bulletDamage = 15;
            Debug.Log("BulletDamage at 15");
            return;
        }
    }

    public void OnRemoveHealth(InputValue value)
    {
        if (value.isPressed) //Press M
        {
            data.currentHealth = 1;
            Debug.Log("Health at 1");
            return;
        }
    }

    public void OnMaxHealth(InputValue value)
    {
        if (value.isPressed) //Press L
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
