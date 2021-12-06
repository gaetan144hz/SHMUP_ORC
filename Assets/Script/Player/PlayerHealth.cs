using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 100;

    public GameObject explosion;

    public HealthBar healthBar;

    public GameObject gameOverUI;
    //public GameObject deathEffect;

    void Start()
    {
        healthBar.SetMaxHealth(playerHealth);
    }
    public void TakeDamage(int enemyBullet)
    {
        playerHealth -= enemyBullet;
        if (playerHealth <= 0)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
            Die();
        }

        healthBar.SetHealth(playerHealth);
    }

    void Die()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

