using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    [SerializeField] float waitingSecond;

    Coroutine coroutineSpawn;

    private void Start()
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

    IEnumerator Spawn()
    {
        while (true)
        {
            spawn1();
            yield return new WaitForSeconds(6);
            spawn1();
            spawn1();
            yield return new WaitForSeconds(12);
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(18);
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
            yield return new WaitForSeconds(30);
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            spawn1();
            yield return new WaitForSeconds(36);
            Debug.Log("BOSS");
            //yield return new WaitForSeconds(180);
        }
    }
}
