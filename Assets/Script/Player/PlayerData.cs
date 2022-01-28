using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "SHMUP_Player/Player Data")]
public class PlayerData : ScriptableObject
{
    private void OnEnable()
    {
        currentHealth = startHealth;
        speed = startSpeed;

        bulletDamage = startBulletDamage;
        bulletSpeed = startBulletSpeed;

        startSpellDamage = spellDamage;
        startSpellSpeed = spellSpeed;
    }

    [Header("PLayer Movement")]
    public float speed;
    [HideInInspector] public float startSpeed;

    [Header("Health")]
    public int startHealth;
    [HideInInspector] public int currentHealth;

    [Header("Bullet Settings")]
    public int bulletDamage;
    [HideInInspector] public int startBulletDamage;
    public int bulletSpeed;
    [HideInInspector] public int startBulletSpeed;
    public int spellDamage;
    [HideInInspector] public int startSpellDamage;
    public int spellSpeed;
    [HideInInspector] public int startSpellSpeed;

    [Header("AnimationDeath")]
    public GameObject explosion;
}
