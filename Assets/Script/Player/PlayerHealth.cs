using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerData datap;

    public GameObject explosion;

    public HealthBar healthBar;

    public GameObject gameOverUI;

    public PlayerMovement playerMovement;
    //public GameObject deathEffect;

    void Start()
    {       
        healthBar.SetMaxHealth(datap.currentHealth);
    }
    public void TakeDamage(int enemyBullet)
    {
        datap.currentHealth -= enemyBullet;
        if (datap.currentHealth <= 0)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
            Die();
        }

        healthBar.SetHealth(datap.currentHealth);
    }

    void Die()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        PlayerMovement.playerList.Remove(playerMovement);
        Destroy(GetComponent<PlayerMovement>());
        Destroy(GetComponent<PrincipalWeapon>());
    }
}

