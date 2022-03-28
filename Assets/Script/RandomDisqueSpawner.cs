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
    private ScoreSetup scoreSetup;

    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    [SerializeField] float waitingSecond;

    public void Awake()
    {
        scoreSetup = FindObjectOfType<ScoreSetup>();
        StartCoroutine(waitForDiskLaunch());
    }

    public void spawn1(int randEnemy, int randSpawnPoint)
    {
        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
    }

    IEnumerator waitForDiskLaunch()
    {
        yield return new WaitUntil(() => scoreSetup.killCount == 3);
        StartCoroutine(disqueSpawn());
    }

    IEnumerator disqueSpawn()
    {
        while (true)
        {
            spawn1(Random.Range(0, enemyPrefabs.Length), Random.Range(0, spawnPoints.Length));
            yield return new WaitForSeconds(waitingSecond);
        }
    }
}
