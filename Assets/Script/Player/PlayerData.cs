using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "SHMUP_Player/Player Data")]
public class PlayerData : ScriptableObject
{
    private void OnEnable()
    {
        currentHealth = startHealth;
        speed = startSpeed;
    }

    public float speed;
    public float startSpeed;

    public int startHealth;
    public int currentHealth;

    public GameObject explosion;

    public int bulletDamage;
    
    public int bulletSpeed;

}
