using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "SHMUP_Enemy/Enemy Data")]
public class EnemyData : ScriptableObject
{
    public string Enemy;

    public string Description;
    public GameObject EnemyModel;
    public int health = 100;

    public float speed = 1f;

    public float bulletSpeed = 1f;
    public int bulletDamage = 1;
    public int healIncrease = 10;

    public float range = 0;
    public float shootingRange = 10;
}
