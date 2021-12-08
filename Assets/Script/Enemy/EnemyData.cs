using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "SHMUP_Enemy/Enemy Data")]
public class EnemyData : ScriptableObject
{
    private void OnEnable()
    {
        currentHealth = startHealth;
        bulletSpeed = currentbulletSpeed;
    }

    public string Enemy;

    public string Description;
    public GameObject EnemyModel;
    public int currentHealth;
    public int startHealth;

    public float speed;

    public float currentbulletSpeed;

    private float bulletSpeed;
    public int bulletDamage;
    public float fireRate;

    public int healIncrease;

    public float range;
    public float shootingRange;
}
