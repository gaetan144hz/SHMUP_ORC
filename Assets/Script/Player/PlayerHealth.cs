using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth = 100;

    //public GameObject deathEffect;

    public void TakeDamage(int enemyBullet)
    {
        playerHealth -= enemyBullet;
        if (playerHealth <= 0)
        {
            Time.timeScale = 0f;
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}

