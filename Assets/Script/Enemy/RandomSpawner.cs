using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    //[SerializeField] float speed;
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    private Transform[] firePoint;
    
    //[SerializeField] private Transform firePoint;
    //private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb.GetComponent<Rigidbody2D>();
        //rb.velocity = transform.right * speed;
        spawn();
    }

    public void spawn()
    {
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
        Instantiate(enemyPrefabs[1], firePoint[randSpawnPoint].position, transform.rotation);
    }
}
