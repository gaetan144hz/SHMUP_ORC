using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePattern_01 : MonoBehaviour
{
    public GameObject bullet;

    [SerializeField] private float fireRate;

    void Awake()
    {
        Invoke("shoot", fireRate);
    }

    void Update()
    {
        
    }

    public void shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

}
