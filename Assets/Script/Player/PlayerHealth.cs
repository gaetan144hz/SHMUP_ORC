using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 100;

    public HealthBar healthBar;
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
            Time.timeScale = 0f;
            Die();
        }

        healthBar.SetHealth(playerHealth);
    }

    void Die()
    {
        Destroy(gameObject);
    }
}

