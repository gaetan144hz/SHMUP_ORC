using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "SHMUP_Player/Player Data")]
public class PlayerData : ScriptableObject
{
    private void OnEnable()
    {
        currentHealth = startHealth;
        speed = startSpeed;
        bulletDamage = startBulletDamage;
        bulletSpeed = startBulletSpeed;
    }

    [Header("PLayer Movement")]
    public float speed;
    [HideInInspector] public float startSpeed;

    [Header("Health")]
    public int startHealth;
    [HideInInspector] public int currentHealth;

    [Header("Bullet Settings")]
    public int bulletDamage;
    [HideInInspector] public int startBulletDamage;
    [HideInInspector] public int bulletSpeed;
    public int startBulletSpeed;

    [Header("AnimationDeath")]
    public GameObject explosion;
}
