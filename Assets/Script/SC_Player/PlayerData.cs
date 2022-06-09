using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "SHMUP_Player/Player Data")]
public class PlayerData : ScriptableObject
{
    public void OnEnable()
    {
        Time.timeScale = 1f;

        currentHealth = startHealth;
        currenSpeed = speed;

        currenntBulletDamage = bulletDamage;
        currentBulletSpeed = bulletSpeed;

        currentSpellDamage = spellDamage;
        currentSpellSpeed = spellSpeed;

        currentSpellCooldown = spellCooldown;

        currentShieldCooldown = shieldCooldown;
    }

    [Header("Player Movement")]
    [HideInInspector] public float currenSpeed;
    public float speed;
    public float maxSpeed;
    
    [Header("Health")]
    public float startHealth;
    public float currentHealth;

    [Header("Bullet Settings")]
    public int bulletSpeed;
    public int bulletDamage;
    [HideInInspector] public int currenntBulletDamage;
    [HideInInspector] public int currentBulletSpeed;

    [Header("Dash")]
    public float shieldCooldown;
    [HideInInspector] public float currentShieldCooldown;
    
    [Header("Spell Settings")]
    public float spellCooldown;
    [HideInInspector] public float currentSpellCooldown;

    [Header("Spell Settings")]
    public int spellDamage;
    public int spellSpeed;
    [HideInInspector] public int currentSpellDamage;
    [HideInInspector] public int currentSpellSpeed;
    

    [Header("FXDeath")]
    public GameObject explosion;
}
