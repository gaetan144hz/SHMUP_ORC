using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "SHMUP_Enemy/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public void OnEnable()
    {
        currentHealth = startHealth ;

        bulletSpeed = startBulletSpeed;
        bulletDamage = startBulletDamage;

        patternBulletDamage = startPatternBulletDamage;

        spellDamage = startSpellDamage;
        spellSpeed = startSpellSpeed;

        currentSpeedMovement = startSpeedMovement;
        
        currentPatternFireRate = startPatternFireRate;
    }

    [Header("Enemy Information")]
    public string Enemy;
    public GameObject EnemyModel;
    [TextArea]
    public string Description;
    public int Score;

    [Header("Enemy Movement")]
    [HideInInspector] public float currentSpeedMovement;
    public float startSpeedMovement;

    [Header("Health")]
    public int currentHealth;
    public int startHealth;

    [Header("Bullet Speed")]
    [HideInInspector] public float bulletSpeed;
    public float startBulletSpeed;

    [Header("Bullet Damage")]
    [HideInInspector] public int bulletDamage;
    public int startBulletDamage;
    public int patternBulletDamage;
    public int startPatternBulletDamage;

    [Header("Spell Speed")]
    [HideInInspector] public float spellSpeed;
    public float startSpellSpeed;
     
    [Header("Spell Damage")]
    [HideInInspector] public int spellDamage;
    public int startSpellDamage;

    [Header("FireRate")]
    public float fireRate;
    public float currentPatternFireRate;
    public float startPatternFireRate;

    [Header("Only for Mage")]
    public int healIncrease;

    [Header("Range of Detection")]
    public float range;
    public float shootingRange;
}