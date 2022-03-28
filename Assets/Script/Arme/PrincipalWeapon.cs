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
    private float cooldownTime;
    private bool spellReady;

    [Header("FirePoint")]
    public Transform[] firePoint;

    [Header("Bullet")]
    public GameObject[] bulletPrefab;
    //public Transform[] spawnPoints;

    //[SerializeField] private float bulletForce;

    private Rigidbody2D rb;

    public void Start()
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
        Instantiate(bulletPrefab[0], firePoint[0].position, firePoint[0].rotation);
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
        CameraShake.Instance.shakeCamera(3f,0.1f);
        Instantiate(bulletPrefab[1], firePoint[0].position, firePoint[0].rotation);
        Instantiate(bulletPrefab[1], firePoint[1].position, firePoint[1].rotation);
        Instantiate(bulletPrefab[1], firePoint[2].position, firePoint[2].rotation);
        Instantiate(bulletPrefab[1], firePoint[3].position, firePoint[3].rotation);
        Instantiate(bulletPrefab[1], firePoint[4].position, firePoint[4].rotation);
        Instantiate(bulletPrefab[1], firePoint[5].position, firePoint[5].rotation);
        Instantiate(bulletPrefab[1], firePoint[6].position, firePoint[6].rotation);
        Instantiate(bulletPrefab[1], firePoint[7].position, firePoint[7].rotation);
        Instantiate(bulletPrefab[1], firePoint[8].position, firePoint[8].rotation);
        Instantiate(bulletPrefab[1], firePoint[9].position, firePoint[9].rotation);
        Instantiate(bulletPrefab[1], firePoint[10].position, firePoint[10].rotation);
    }

    public IEnumerator cooldownTripleShot()
    {
        cooldownTime = datap.currentCooldown;

        while (cooldownTime > 0)
        {
            textCooldown.text = cooldownTime.ToString("0");
            cooldownTime -= 1;
            if (cooldownTime <= 0)
            {
                spellReady = true;
                textCooldown.text = "A Ready!";
            }
            else
            {
                textCooldown.text = cooldownTime.ToString("0");
                yield return new WaitForSeconds(1);
            }
        }
    }
}
