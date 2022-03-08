using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    Timer timer;
    RandomSpawner randomSpawner;

    GameObject[] spawner;

    void Start()
    {
        randomSpawner = FindObjectOfType<RandomSpawner>();
        timer = FindObjectOfType<Timer>();
    }

    void Update()
    {
        if(timer.currentTime >= 6)
        {
            spawner[1].SetActive(false);
            spawner[2].SetActive(true);
        }
        if (timer.currentTime >= 18)
        {
            spawner[2].SetActive(false);
            spawner[3].SetActive(true);
        }
        if (timer.currentTime >= 36)
        {
            spawner[3].SetActive(false);
            spawner[4].SetActive(true);
        }
        if (timer.currentTime >= 6)
        {
            spawner[4].SetActive(false);
            spawner[5].SetActive(true);
        }
        if (timer.currentTime >= 6)
        {
            spawner[5].SetActive(false);
            spawner[6].SetActive(true);
        }
        if (timer.currentTime >= 6)
        {
            spawner[6].SetActive(false);
            spawner[7].SetActive(true);
        }
    }
}
