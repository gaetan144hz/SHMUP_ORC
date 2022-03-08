using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class cheat : MonoBehaviour
{
    public PlayerData datap;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void cheatDamage()
    {
        datap.spellDamage = 999;
        datap.bulletDamage = 999;
    }

    public void playerHealth()
    {
        datap.currentHealth = 97979797;
    }

    public void cheatSpeed()
    {
        datap.speed = 10;
    }

    public void cheatBulletSpeed()
    {
        datap.bulletSpeed = 20;
        datap.spellSpeed = 25;
    }
}
