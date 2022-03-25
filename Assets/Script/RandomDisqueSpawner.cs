using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomDisqueSpawner : MonoBehaviour
{
    [TextArea]
    public string Description;

    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    [SerializeField] float waitingSecond;

    public void Start()
    {
        StartCoroutine(disqueSpawn());
    }

    public void spawn1()
    {
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
    }

    IEnumerator disqueSpawn()
    {
        while (true)
        {
            spawn1();
            yield return new WaitForSeconds(waitingSecond);
        }
    }
}
