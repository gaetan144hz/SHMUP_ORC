using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class TestSpawnUnitaire : MonoBehaviour
{
    [Header("SpwnEnemy Controls")]
    public Transform[] spawnPointEnemy;
    public GameObject[] enemyPrefabs;
    public TMP_InputField[] InputFieldEnemy;

    [Header("SpwnPowerUp Controls")]
    public Transform[] spawnPointPowerUp;
    public GameObject[] powerUpPrefabs;
    public TMP_InputField[] InputFieldPowerUp;
    
    public GameObject[] ui;

    public int enemyNumber;
    public int powerUpNumber;

    #region SpawnEnemyRegion
    public void allEn()
    {
        spawnDe();
        spawnMe();
        spawnGe();
    }
    public void rgEn()
    {
        spawnDe();
        spawnGe();
    }
    
    public void spawnDe()
    {
        enemyNumber = Int32.Parse(InputFieldEnemy[2].text);
        Instantiate(enemyPrefabs[enemyNumber], spawnPointEnemy[2].position, spawnPointEnemy[2].rotation);
    }
    public void spawnMe()
    {
        enemyNumber = Int32.Parse(InputFieldEnemy[1].text);
        Instantiate(enemyPrefabs[enemyNumber], spawnPointEnemy[1].position, spawnPointEnemy[1].rotation);
    }
    public void spawnGe()
    {
        enemyNumber = Int32.Parse(InputFieldEnemy[0].text);
        Instantiate(enemyPrefabs[enemyNumber], spawnPointEnemy[0].position, spawnPointEnemy[0].rotation);
    }

    #endregion

    #region SpawnPowerUpRegion
    public void allPw()
    {
        spawnGPw();
        spawnMPw();
        spawnDPw();
    }
    public void rgPw()
    {
        spawnGPw();
        spawnDPw();
    }
    
    public void spawnDPw()
    {
        powerUpNumber = Int32.Parse(InputFieldPowerUp[2].text);
        Instantiate(powerUpPrefabs[powerUpNumber], spawnPointPowerUp[2].position, spawnPointPowerUp[2].rotation);
    }
    public void spawnMPw()
    {
        powerUpNumber = Int32.Parse(InputFieldPowerUp[1].text);
        Instantiate(powerUpPrefabs[powerUpNumber], spawnPointPowerUp[1].position, spawnPointPowerUp[1].rotation);
    }
    public void spawnGPw()
    {
        powerUpNumber = Int32.Parse(InputFieldPowerUp[0].text);
        Instantiate(powerUpPrefabs[powerUpNumber], spawnPointPowerUp[0].position, spawnPointPowerUp[0].rotation);
    }

    #endregion

    #region DisableUI
    public void disableSpUI()
    {
        foreach (var canvas in ui)
        {
            canvas.SetActive(false);
        }
    }

    public void enableSpUI()
    {
        foreach (var canvas in ui)
        {
            canvas.SetActive(true);
        }
    }

    #endregion
    
}
