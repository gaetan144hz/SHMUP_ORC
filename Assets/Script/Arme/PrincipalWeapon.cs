using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PrincipalWeapon : MonoBehaviour
{
    private void OnEnable()
    {
        datap.OnEnable();
    }

    [Header("Data")]
    public PlayerData datap;

    [Header("TextCooldown")]
    public TextMeshProUGUI textCooldown;

    [Header("BulletColdown")]
    [SerializeField] private float cooldown;
    private float lastShot;

    [Header("FirePoint")]
    [SerializeField] Transform firePoint;
    [SerializeField] Transform firePointDroite;
    [SerializeField] Transform firePointGauche;

    [Header("Bullet")]
    public GameObject[] bulletPrefab;
    //public Transform[] spawnPoints;

    //[SerializeField] private float bulletForce;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        textCooldown.text = cooldown.ToString();
    }

    public void OnShoot(InputValue value)
    {
        if (value.isPressed)
        {
            Shoot();
            return;
        }
    }

    public void OnTripleShoot(InputValue value)
    {
        if (value.isPressed)
        {
            TripleShoot();
            return;
        }
    }

    public void Shoot()
    {
        /*
        for (int i = 0; i < bulletPrefab.Length; i++)
        {
            if (i >= nombreDeTirAutorise)
                return;
        }
        */
        Instantiate(bulletPrefab[0], firePoint.position, firePoint.rotation);
        //Instantiate(bulletPrefab[0], firePointDroite.position, firePointDroite.rotation);
        //Instantiate(bulletPrefab[0], firePointGauche.position, firePointGauche.rotation);
    }

    public void TripleShoot()
    {
        if (Time.time - lastShot < cooldown)
        {
            return;
        }
        lastShot = Time.time;    
        Instantiate(bulletPrefab[1], firePoint.position, firePoint.rotation);
        Instantiate(bulletPrefab[1], firePointDroite.position, firePointDroite.rotation);
        Instantiate(bulletPrefab[1], firePointGauche.position, firePointGauche.rotation);
    }
}
