using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class PrincipalWeapon : MonoBehaviour
{
    private void OnEnable()
    {
        datap.OnEnable();
    }

    private PlayerInput _playerInput;

    [Header("Data")]
    public PlayerData datap;

    private PauseResume _pauseResume;

    [Header("TextCooldown")]
    public TextMeshProUGUI textCooldown;

    [Header("SpellImage")]
    public Image spellImage;

    [Header("BulletColdown")]
    private float cooldownTime;
    private bool spellReady;

    [Header("FirePoint")]
    public Transform[] firePoint;

    [Header("Bullet")]
    public GameObject[] bulletPrefab;
    public bool shootBool;
    public float autoFireRate;
    //public Transform[] spawnPoints;

    //[SerializeField] private float bulletForce;
    private Rigidbody2D rb;

    public void Start()
    {
        _pauseResume = FindObjectOfType<PauseResume>();
        
        rb = GetComponent<Rigidbody2D>();
        spellReady = true;
        spellImage.fillAmount = 1;
        shootBool = false;
        autoFireRate = 0.1f;
    }

    
    
    #region ShootAuto
    
    public void OnShoot(InputValue value)
    {
        if (value.isPressed && _pauseResume.shootStatus == true)
        {
            shootBool = true;
            //StartCoroutine(autoShoot());
            Shoot();
            return;
        }
        else
        {
            shootBool = false;
            return;
        }
    }

    public IEnumerator autoShoot()
    {
        while (shootBool == true)
        {
            Shoot();
            yield return new WaitForSeconds(autoFireRate);
        }
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab[0], firePoint[0].position, firePoint[0].rotation);

        /*
        for (int i = 0; i < bulletPrefab.Length; i++)
        {
            if (i >= nombreDeTirAutorise)
                return;
        }
        */
    }
    
    #endregion
    
    

    #region Spell
    
    public void OnTripleShoot(InputValue value)
    {
        if (value.isPressed && _pauseResume.shootStatus == true)
        {
            //Gamepad.current.SetMotorSpeeds(0.25f, 0.75f);   
            TripleShoot();
            return;
        }
        else
        {
            return;
        }
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
        spellImage.fillAmount = 0;

        while (cooldownTime > 0)
        {
            textCooldown.text = cooldownTime.ToString("0");
            spellImage.fillAmount += 1/datap.currentCooldown;
            cooldownTime -= 1;
            if (cooldownTime <= 0)
            {
                spellReady = true;
                textCooldown.text = "A";
                spellImage.fillAmount = 1;
            }
            else
            {
                textCooldown.text = cooldownTime.ToString("0");
                yield return new WaitForSeconds(1);
            }
        }
    }
    
    #endregion
}
