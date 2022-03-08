using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDisqueSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    [SerializeField] float waitingSecond;

    Coroutine coroutineSpawn;

    private void Start()
    {
        coroutineSpawn = StartCoroutine(disqueSpawn());
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
