using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawnUnitaire : MonoBehaviour
{
    public Transform[] spawnePoint;
    
    public GameObject[] enemyPrefabs;

    [SerializeField] private int enemyNumber;

    public void spawn()
    {
        Instantiate(enemyPrefabs[enemyNumber], spawnePoint[0].position, spawnePoint[0].rotation);
    }
}
