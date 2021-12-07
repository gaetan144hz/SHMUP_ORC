using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "SHMUP_Player/Player Data")]
public class PlayerData : ScriptableObject
{
    private void OnEnable()
    {
        currentHealth = startHealth;
    }

    public float speed;

    public int startHealth;
    public int currentHealth;

    public GameObject explosion;

    public int bulletDamage;
    
    public int bulletSpeed;

}
