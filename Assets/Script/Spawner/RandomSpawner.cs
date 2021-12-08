using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    [SerializeField] int startWaitingSecond;
    [SerializeField] int waitingSecond;

    Coroutine coroutineSpawn;

    private void Start()
    {
        coroutineSpawn = StartCoroutine(Spawn());
    }

    public void spawn()
    {
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(startWaitingSecond);
            spawn();
            yield return new WaitForSeconds(waitingSecond);
        }
    }
}
