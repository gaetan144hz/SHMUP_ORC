using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] Transform firePointDroite;
    [SerializeField] Transform firePointGauche;

    public GameObject[] bulletPrefab;
    //public Transform[] spawnPoints;

    //[SerializeField] private float bulletForce;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Shoot();
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
        Instantiate(bulletPrefab[0], firePointDroite.position, firePointDroite.rotation);
        Instantiate(bulletPrefab[0], firePointGauche.position, firePointGauche.rotation);
    }
}
