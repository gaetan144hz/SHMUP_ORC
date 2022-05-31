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

        currentDashCooldown = startDashCooldown;
        currentSpeedDash = startSpeedDash;
    }

    [Header("Player Movement")]
    [HideInInspector] public float speed;
    public float startSpeed;
    public float maxSpeed;

    [Header("Dash")] 
    public float currentSpeedDash;
    public float startSpeedDash;
    public float startDashCooldown;
    public float currentDashCooldown;

    [Header("Health")]
    public float startHealth;
    public float currentHealth;

    [Header("Bullet Settings")]
    public int bulletDamage;
    public int startBulletDamage;
    public int bulletSpeed;
    public int startBulletSpeed;

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
