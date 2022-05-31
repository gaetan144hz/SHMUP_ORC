using System;
using System.Collections;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHealth : MonoBehaviour
{
    public PlayerData datap;

    public GameObject explosion;

    public HealthCounter healthBar;

    private GameOver gameOver;

    public PlayerMovement playerMovement;

    void Awake()
    {
        gameOver = FindObjectOfType<GameOver>();
        healthBar.SetMaxHealth(datap.currentHealth); //NE PAS ENLEVER SINON LA HEALTHBAR NE FONCTIONNE PLUS
    }

    private void Update()
    {
        healthBar.SetHealth(datap.currentHealth);
    }
    
    #region MyRegion
    public void playRumble()
    { 
        Gamepad.current.SetMotorSpeeds(0.5f,0.5f);
        Debug.Log("waiting.....");
        new WaitForSeconds(0.5f);
        Debug.Log("after wait");
        stopRumble();
        Debug.Log("STOP");
    }

    public void stopRumble()
    {
        Gamepad.current.SetMotorSpeeds(0f,0f);
        Gamepad.current.ResetHaptics();
        Debug.Log("STOP");
    }

    #endregion
    
    public void TakeDamage(float ennemyDamage)
    {
        datap.currentHealth -= ennemyDamage;
        healthBar.SetHealth(datap.currentHealth);
        if (datap.currentHealth <= 0)
        {
            Die();
            gameOver.gameOverUI();
        }
    }

    void Die()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        PlayerMovement.playerList.Remove(playerMovement);
        Destroy(GetComponent<PlayerMovement>());
        Destroy(GetComponent<PrincipalWeapon>());
    }
}

