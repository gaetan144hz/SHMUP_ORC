using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    [SerializeField] private float wave1ToWave2;
    [SerializeField] private float wave2ToWave3;
    [SerializeField] private float wave3ToWave4;
    [SerializeField] private float wave4ToWave5;
    [SerializeField] private float wave5ToWave6;
    [SerializeField] private float wave6ToWave7;

    Coroutine coroutineSpawn;

    private void Awake()
    {
        coroutineSpawn = StartCoroutine(Spawn());
    }

    private void Update()
    {
        
    }

    public void spawn1()
    {
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
    }

    public void goblinToTank()
    {
        int randEnemy = Random.Range(0, 2);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
    }

    public void onlyGoblin()
    {
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
        Debug.Log(enemyPrefabs[0]);
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            spawn1();
            spawn1();
            yield return new WaitForSeconds(6);
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(12);
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(18);
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(24);
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(30);
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(32);
            Debug.Log("BOSS");
            //yield return new WaitForSeconds(180);
        }
    }
}
