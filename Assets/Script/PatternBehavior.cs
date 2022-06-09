using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternBehavior : MonoBehaviour
{
    public EnemyData data;
    
    public GameObject[] bullet;

    public Transform[] firePoint;
    
    void Start()
    {
        StartCoroutine(pattern1());
    }
    
    void Update()
    {
        
    }
    
    public IEnumerator pattern1()
    {
        while (true)
        {
            foreach (var firePoints in firePoint)
            {
                shoot(bullet[0], firePoints);
            }
            yield return new WaitForSeconds(data.currentPatternFireRate);
        }
    }
    
    public void shoot(GameObject bullet, Transform firePoint)
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
