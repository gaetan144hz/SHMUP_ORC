/// <summary
/// By QG
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomSpawner : MonoBehaviour
{
    public Wave waveClass;

    [TextArea]
    public string Description;
    public int waveNumber;
    //public int waveValue;
    //public int maxValue;
    //public int stage;

    private int killCap;
    private int waveStage;

    [Header("Collections")]
    public Wave[] waves;

    private ScoreSetup ScoreSetup;

    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public GameObject wavesObject;
    public TextMeshProUGUI wavesText;
    public TextMeshProUGUI wavesCounter;
    public Animator animator;

    public void Awake()
    {
        ScoreSetup = FindObjectOfType<ScoreSetup>();
        //stage = 5;
    }

    public void gameInstantiate()
    {
        //waveValue = 0;
        //StartCoroutine(Wave1());
        killCap = 1;
        StartCoroutine(WavesLauncher());
    }
    
    public void wave(int enemyValue, int spawnValue)
    {
        Instantiate(enemyPrefabs[enemyValue], spawnPoints[spawnValue].position, spawnPoints[spawnValue].rotation);
    }

    IEnumerator WaveAnim()
    {
        waveNumber += 1;
        wavesCounter.text = $"VAGUE: {waveNumber}";
        var textInput = $"WAVE {waveNumber}";
        yield return new WaitForSeconds(1);
        wavesText.text = textInput;
        wavesObject.SetActive(true);
        animator.Play("Anim_WaveText");
        yield return new WaitForSeconds(1);
        wavesObject.SetActive(false);
        wavesObject.SetActive(true);
        wavesText.text = "START !";
        animator.Play("Anim_WaveText");
        yield return new WaitForSeconds(1);
        wavesObject.SetActive(false);
    }

    /*IEnumerator Wave1()
    {
        while (waveValue <= 0)
        {
            StartCoroutine(WaveAnim());
            yield return new WaitForSeconds(3);
            wave(0, Random.Range(0, spawnPoints.Length));
            yield return new WaitUntil(() => ScoreSetup.killCount == 1);
            waveValue = 1;
            maxValue = 2;
            StartCoroutine(WaveManager());
        }
    }

    IEnumerator WaveSetup()
    {
        for (int i = 1; i < maxValue; i++)
        {
            wave(Random.Range(0, enemyPrefabs.Length), Random.Range(0, spawnPoints.Length));
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator WaveManager()
    {
        while (true)
        {
            if(waveNumber >= stage)
            {
                maxValue = stage;
            }

            StartCoroutine(WaveAnim());
            yield return new WaitForSeconds(3);
            var killNeeded = ScoreSetup.killCount + maxValue;
            StartCoroutine(WaveSetup());
            maxValue += 1;
            yield return new WaitUntil(() => ScoreSetup.killCount == killNeeded);
        }
    }*/

    IEnumerator WavesLauncher()
    {
        foreach (var wave in waves)
        {
            StartCoroutine(WaveAnim());
            yield return new WaitForSeconds(3);
            WaveSpawn();
            yield return new WaitUntil(() => ScoreSetup.killCount == killCap);
        }
    }

    public void WaveSpawn()
    {
        foreach (var enemy in waveClass.enemies)
        {
            Debug.Log("ok");
            Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Length)].position, spawnPoints[Random.Range(0, spawnPoints.Length)].rotation);
            killCap += 1;
        }
    }
}

[System.Serializable]

public class Wave
{
    public GameObject[] enemies;
}