using System;
using System.Collections;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using Random = UnityEngine.Random;

public class PlayerHealth : MonoBehaviour
{
    public PlayerData datap;
    
    [Header("Audio")]
    public AudioClip[] sound;
    public AudioSource source;

    public GameObject explosion;

    private GameOver gameOver;

    public PlayerMovement playerMovement;

    public TextMeshProUGUI healthText;
    public Gradient gradient;

    void Awake()
    {
        gameOver = FindObjectOfType<GameOver>();
        healthText.text = datap.currentHealth.ToString("0"); //NE PAS ENLEVER SINON LA HEALTHBAR NE FONCTIONNE PLUS
        healthText.color = gradient.Evaluate(1f);
    }

    private void Update()
    {
        if (datap.currentHealth <= 0)
        {
            Die();
            gameOver.gameOverUI();
        }
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

    public void TakeDamage(float damage)
    {
        var index = Random.Range(0, sound.Length);
        source.clip = sound[index];
        source.Play();
        
        StartCoroutine(Damage(damage));
    }

    public IEnumerator Damage(float damage)
    {
        for (int i = 0; i < damage; i++)
        {
            datap.currentHealth--;
            healthText.text = datap.currentHealth.ToString("0");
            healthText.color = gradient.Evaluate(datap.currentHealth / datap.startHealth);
            yield return new WaitForFixedUpdate();
        }
    }

    public IEnumerator Heal(float heal)
    {
        for (int i = 0; i < heal; i++)
        {
            datap.currentHealth++;
            healthText.text = datap.currentHealth.ToString("0");
            healthText.color = gradient.Evaluate(datap.currentHealth / datap.startHealth);
            if (datap.currentHealth >= 300) 
            { 
                datap.currentHealth = 300;
                healthText.text = datap.currentHealth.ToString("0");
                healthText.color = gradient.Evaluate(datap.currentHealth / datap.startHealth);
            }
            yield return new WaitForFixedUpdate();
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

