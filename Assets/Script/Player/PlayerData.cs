using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "SHMUP_Player/Player Data")]
public class PlayerData : ScriptableObject
{
    public void OnEnable()
    {
        currentHealth = startHealth;
        speed = startSpeed;

        startBulletDamage = bulletDamage;
        bulletSpeed = startBulletSpeed;

        startSpellDamage = spellDamage;
        startSpellSpeed = spellSpeed;
    }

    [Header("Player Movement")]
    public float speed;
    [HideInInspector] public float startSpeed;

    [Header("Health")]
    public int startHealth;
    public int currentHealth;

    [Header("Bullet Settings")]
    public int bulletDamage;
    [HideInInspector] public int startBulletDamage;
    public int bulletSpeed;
    [HideInInspector] public int startBulletSpeed;
    public int spellDamage;
    [HideInInspector] public int startSpellDamage;
    public int spellSpeed;
    [HideInInspector] public int startSpellSpeed;

    [Header("AnimationDeath")]
    public GameObject explosion;
}
