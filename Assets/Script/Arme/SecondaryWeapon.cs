using UnityEngine;
using UnityEngine.InputSystem;

public class SecondaryWeapon : MonoBehaviour
{
    [SerializeField] Transform firePointDroite;
    [SerializeField] Transform firePointGauche;

    public GameObject[] bulletPrefab;

    public void shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            secondaryShoot();
            return;
        }
    }

    public void secondaryShoot()
    {
        Instantiate(bulletPrefab[0], firePointDroite.position, firePointDroite.rotation);
        Instantiate(bulletPrefab[0], firePointGauche.position, firePointGauche.rotation);
    }
}

/*
        for (int i = 0; i < bulletPrefab.Length; i++)
        {
            if (i >= nombreDeTirAutorise)
                return;
        }
        */
