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
    public float speedMovement;
    [HideInInspector] public float currentSpeedMovement;
    

    [Header("Health")]
    public int currentHealth;
    public int startHealth;

    [Header("Bullet Speed")]
    public float bulletSpeed;
    [HideInInspector] public float currentBulletSpeed;

    [Header("Bullet Damage")]
    public int bulletDamage;
    public int patternBulletDamage;
    [HideInInspector] public int currentBulletDamage;
    [HideInInspector] public int currentPatternBulletDamage;
    

    [Header("Spell Speed")]
    public float spellSpeed;
    [HideInInspector] public float currentSpellSpeed;
    
     
    [Header("Spell Damage")]
    public int spellDamage;
    [HideInInspector] public int currentSpellDamage;
    

    [Header("FireRate")]
    public float fireRate;
    public float patternFireRate;
    [HideInInspector] public float currentPatternFireRate;
    

    [Header("Range of Detection")]
    public float range;
    public float shootingRange;
}