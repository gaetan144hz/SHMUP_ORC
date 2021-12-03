using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    EnemyData data;

    public void TakeDamage(int playerDamage)
    {
        data.currentHealth -= playerDamage;
        if (data.currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "skybarriere")
        {
            Destroy(gameObject);
        }
    }
}
