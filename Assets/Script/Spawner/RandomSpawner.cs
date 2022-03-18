using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public EnemyData data;

    private void OnEnable()
    {
        data.OnEnable(); //???????????????//
    }

    [TextArea]
    public string Description;

    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    [SerializeField] private float wave1ToWave2;
    [SerializeField] private float wave2ToWave3;
    [SerializeField] private float wave3ToWave4;
    [SerializeField] private float wave4ToWave5;
    [SerializeField] private float wave5ToWave6;
    [SerializeField] private float wave6ToWave7;

    public void Start()
    {
        StartCoroutine(Spawn());
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

    /*
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
    */

    IEnumerator Spawn()
    {
        while (true)
        {
            spawn1();
            spawn1();
            yield return new WaitForSeconds(wave1ToWave2);
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(wave2ToWave3);
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(wave3ToWave4);
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(wave4ToWave5);
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(wave5ToWave6);
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(wave6ToWave7);
            Debug.Log("BOSS");
            //yield return new WaitForSeconds(180);
        }
    }
}
