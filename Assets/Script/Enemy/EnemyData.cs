using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "SHMUP_Enemy/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public void OnEnable()
    {
        currentHealth = startHealth ;

        currentBulletSpeed = bulletSpeed;
        currentBulletDamage = bulletDamage;

        currentPatternBulletDamage = patternBulletDamage;

        currentSpellDamage = spellDamage;
        currentSpellSpeed = spellSpeed;

        currentSpeedMovement = speedMovement;
        
        currentPatternFireRate = patternFireRate;
    }

    [Header("Enemy Information")]
    public GameObject EnemyModel;
    [TextArea]
    public string Note;
    //public int Score;

    [Header("Enemy Movement")]
    [HideInInspector] public float currentSpeedMovement;
    public float speedMovement;

    [Header("Health")]
    public int currentHealth;
    public int startHealth;

    [Header("Bullet Speed")]
    [HideInInspector] public float currentBulletSpeed;
    public float bulletSpeed;

    [Header("Bullet Damage")]
    [HideInInspector] public int currentBulletDamage;
    public int bulletDamage;
    [HideInInspector] public int currentPatternBulletDamage;
    public int patternBulletDamage;

    [Header("Spell Speed")]
    [HideInInspector] public float currentSpellSpeed;
    public float spellSpeed;
     
    [Header("Spell Damage")]
    [HideInInspector] public int currentSpellDamage;
    public int spellDamage;

    [Header("FireRate")]
    public float fireRate;
    [HideInInspector] public float currentPatternFireRate;
    public float patternFireRate;

    [Header("Range of Detection")]
    public float range;
    public float shootingRange;
}