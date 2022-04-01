using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestSpawnUnitaire : MonoBehaviour
{
    public Transform[] spawnePoint;
    public GameObject[] enemyPrefabs;

    public TMP_InputField[] InputField;
    public int enemy;
/*
    [SerializeField] private int enemyNumberD;
    [SerializeField] private int enemyNumberM;
    [SerializeField] private int enemyNumberG;
*/
    #region SpawnRegion
    
    public void spawnD()
    {
        enemy = Int32.Parse(InputField[0].text);
        Instantiate(enemyPrefabs[enemy], spawnePoint[0].position, spawnePoint[0].rotation);
    }
    public void spawnM()
    {
        enemy = Int32.Parse(InputField[1].text);
        Instantiate(enemyPrefabs[enemy], spawnePoint[1].position, spawnePoint[1].rotation);
    }
    public void spawnG()
    {
        enemy = Int32.Parse(InputField[2].text);
        Instantiate(enemyPrefabs[enemy], spawnePoint[2].position, spawnePoint[2].rotation);
    }
    
    #endregion
    
}
