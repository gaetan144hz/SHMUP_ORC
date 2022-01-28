using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public Timer time;

    public GameObject bossPrefabs;
    private bool bossSpawned;

    public Transform bossSpawnPoint;

    private void Start()
    {
       time = this.GetComponent<Timer>();
    }

    private void Update()
    {
        if (!bossSpawned) // ! inverse le booleen
        {
            spawn();
        }      
    }

    public void spawn()
    {
        if (time.currentTime >= 60f)
        {
            bossSpawned = true;
            Instantiate(bossPrefabs,bossSpawnPoint.position, transform.rotation);
            Destroy(this);
        }       
    }
}
