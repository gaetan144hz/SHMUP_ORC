using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerData datap;

    public GameObject explosion;

    public HealthBar healthBar;

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

    public void TakeDamage(int ennemyDamage)
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

