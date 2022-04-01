using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawnUnitaire : MonoBehaviour
{
    public Transform[] spawnePoint;
    
    public GameObject[] enemyPrefabs;

    [SerializeField] private int enemyNumberD;
    [SerializeField] private int enemyNumberM;
    [SerializeField] private int enemyNumberG;

    public void spawnD()
    {
        Instantiate(enemyPrefabs[enemyNumberD], spawnePoint[0].position, spawnePoint[0].rotation);
    }
    public void spawnM()
    {
        Instantiate(enemyPrefabs[enemyNumberM], spawnePoint[1].position, spawnePoint[1].rotation);
    }
    public void spawnG()
    {
        Instantiate(enemyPrefabs[enemyNumberG], spawnePoint[2].position, spawnePoint[2].rotation);
    }
}
