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
    }

    [Header("Player Movement")]
    public float speed;
    [HideInInspector] public float startSpeed;

    [Header("Health")]
    public int startHealth;
    public int currentHealth;

    [Header("Bullet Settings")]
    public int bulletDamage;
    public int bulletSpeed;
    [HideInInspector] public int startBulletDamage;
    [HideInInspector] public int startBulletSpeed;
    public int spellDamage;
    [HideInInspector] public int startSpellDamage;
    public int spellSpeed;
    [HideInInspector] public int startSpellSpeed;

    [Header("AnimationDeath")]
    public GameObject explosion;
}
