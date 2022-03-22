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
        //healthBar.SetMaxHealth(datap.currentHealth);
    }

    public void TakeDamage(int ennemyDamage)
    {
        datap.currentHealth -= ennemyDamage;
        if (datap.currentHealth <= 0)
        {
            Die();
            gameOver.gameOverUI();
        }
        healthBar.SetHealth(datap.currentHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathZone")
        {
            Die();
            gameOver.gameOverUI();
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

