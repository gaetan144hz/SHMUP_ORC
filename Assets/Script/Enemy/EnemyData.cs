using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "SHMUP_Enemy/Enemy Data")]
public class EnemyData : ScriptableObject
{
    private void OnEnable()
    {
        currentHealth = startHealth;
        bulletSpeed = startBulletSpeed;
        bulletDamage = startBulletDamage;
    }

    [Header("Enemy Information")]
    public string Enemy;
    public GameObject EnemyModel;
    [TextArea]
    public string Description;

    [Header("Enemy Movement")]
    public float speed;

    [Header("Health")]
    [HideInInspector] public int currentHealth;
    public int startHealth;

    [Header("Bullet Speed")]
    [HideInInspector] public float bulletSpeed;
    public float startBulletSpeed;
    [Header("Bullet Damage")]
    [HideInInspector] public int bulletDamage;
    public int startBulletDamage;
    [Space(5)]
    public float fireRate;

    [Header("Only for Mage")]
    public int healIncrease;

    [Header("Range of Detection")]
    public float range;
    public float shootingRange;
}
