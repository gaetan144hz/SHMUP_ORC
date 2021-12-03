using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    //[SerializeField] float fireRate = 1f;
    //private float nextFireTime;
    [SerializeField] Transform firePoint;
    [SerializeField] Transform firePointDroite;
    [SerializeField] Transform firePointGauche;
    public GameObject[] bulletPrefab;
    //public Transform[] spawnPoints;

    //[SerializeField] private float bulletForce;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = transform.right * speed;
    }

    public void shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Shoot();
            return;
            //shootUpgrade();
        }
        //nextFireTime = Time.time + fireRate;
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
        Instantiate(bulletPrefab[0], firePointDroite.position, firePointDroite.rotation);
        Instantiate(bulletPrefab[0], firePointGauche.position, firePointGauche.rotation);
    }
    /*
    void shootUpgrade()
    {
        Instantiate(bulletPrefab[0], firePointDroite.position, firePointDroite.rotation);
        Instantiate(bulletPrefab[0], firePointGauche.position, firePointGauche.rotation);
    }
    */
}
