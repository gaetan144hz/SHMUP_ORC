using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Collections;

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
    [SerializeField] private int cooldown;
    private int cooldownTime;
    private bool spellReady;

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
        spellReady = true;
    }

    private void Update()
    {
        //textCooldown.text = cooldown.ToString("0");
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
        if (spellReady == false)
        {
            return;
        }
        spellReady = false;
        StartCoroutine(cooldownTripleShot());
        Instantiate(bulletPrefab[1], firePoint.position, firePoint.rotation);
        Instantiate(bulletPrefab[1], firePointDroite.position, firePointDroite.rotation);
        Instantiate(bulletPrefab[1], firePointGauche.position, firePointGauche.rotation);
    }

    IEnumerator cooldownTripleShot()
    {
        cooldownTime = cooldown;

        while (cooldownTime > 0)
        {
            textCooldown.text = cooldownTime.ToString("0");
            cooldownTime -= 1;
            if (cooldownTime == 0)
            {
                spellReady = true;
                textCooldown.text = "Ready !";
            }
            else
            {
                textCooldown.text = cooldownTime.ToString("0");
                yield return new WaitForSeconds(1);
            }
        }
    }
}
