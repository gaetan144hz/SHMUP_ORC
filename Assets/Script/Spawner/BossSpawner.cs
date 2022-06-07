using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    private Timer time;
    private ScoreSetup scoreSetup;

    public AudioClip spawnMusic;
    private AudioSource audioSource;
    public GameObject bossPrefabs;
    public bool bossSpawned;
    private float bossTiming;
    private int bossKillCount;

    public Transform bossSpawnPoint;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        scoreSetup = FindObjectOfType<ScoreSetup>();
        time = this.GetComponent<Timer>(); 
        bossTiming = 120;
        bossKillCount = 30;
    }

    private void Update()
    {
        if (!bossSpawned && time.currentTime >= bossTiming) // ! inverse le booleen
        {
            spawn();
        }
        
        if (!bossSpawned && scoreSetup.killCount == bossKillCount)
        {
            spawn();
        }
    }

    public void spawn()
    {
        audioSource.clip = spawnMusic;
        audioSource.Play();
        bossKillCount += 30;
        bossTiming += 120;
        bossSpawned = true;
        Instantiate(bossPrefabs,bossSpawnPoint.position, transform.rotation);
    }
}
