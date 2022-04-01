using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "SHMUP_Player/Player Data")]
public class PlayerData : ScriptableObject
{
    public void OnEnable()
    {
        Time.timeScale = 1f;

        currentHealth = startHealth;
        speed = startSpeed;

        bulletDamage = startBulletDamage;
        bulletSpeed = startBulletSpeed;

        spellDamage = startSpellDamage;
        spellSpeed = startSpellSpeed;

        currentCooldown = startCooldown;
    }

    [Header("Player Movement")]
    [HideInInspector] public float speed;
    public float startSpeed;
    [HideInInspector] public float acceleration;
    public float startAcceleration;
    public float maxSpeed;

    [Header("Health")]
    public int startHealth;
    public int currentHealth;

    [Header("Bullet Settings")]
    public int bulletDamage;
    [HideInInspector] public int startBulletDamage;
    public int bulletSpeed;
    [HideInInspector] public int startBulletSpeed;

    [Header("Spell Settings")]
    public float currentCooldown;
    public float startCooldown;

    [Header("Spell Settings")]
    public int spellDamage;
    public int startSpellDamage;
    public int spellSpeed;
    public int startSpellSpeed;

    [Header("FXDeath")]
    public GameObject explosion;
}
