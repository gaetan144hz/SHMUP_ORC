using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "SHMUP_Enemy/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public void OnEnable()
    {
        currentHealth = startHealth ;

        bulletSpeed = startBulletSpeed;
        bulletDamage = startBulletDamage;

        spellDamage = startSpellDamage;
        spellSpeed = startSpellSpeed;

        currentSpeedMovement = startSpeedMovement;
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

    [Header("Spell Speed")]
    [HideInInspector] public float spellSpeed;
    public float startSpellSpeed;
     
    [Header("Spell Damage")]
    [HideInInspector] public int spellDamage;
    public int startSpellDamage;

    [Space(5)]
    public float fireRate;

    [Header("Only for Mage")]
    public int healIncrease;

    [Header("Range of Detection")]
    public float range;
    public float shootingRange;
}