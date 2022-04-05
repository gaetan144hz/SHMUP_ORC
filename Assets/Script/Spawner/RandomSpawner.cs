/// <summary
/// By QG
/// </summary>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomSpawner : MonoBehaviour
{
    [TextArea]
    public string Description;
    public int waveNumber;
    public int maxValue;
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
        maxValue = 7;
    }

    public void gameInstantiate()
    {
        StartCoroutine(WavesLauncher());
    }

    public void lateGameInstantiate()
    {
        StartCoroutine(LateGame());
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

    IEnumerator WaveSetup()
    {
        for (int i = 0; i < maxValue; i++)
        {
            wave(Random.Range(0, enemyPrefabs.Length), Random.Range(0, spawnPoints.Length));
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator LateGame()
    {
        while (true)
        {
            StartCoroutine(WaveAnim());
            yield return new WaitForSeconds(3);
            var killCap = ScoreSetup.killCount + maxValue;
            StartCoroutine(WaveSetup());
            yield return new WaitUntil(() => ScoreSetup.killCount == killCap);
        }
    }

    IEnumerator WavesLauncher()
    {
        foreach (var wave in waves)
        {
            StartCoroutine(WaveAnim());
            yield return new WaitForSeconds(3);
            StartCoroutine(WaveSpawn());
            var killCap = ScoreSetup.killCount + waves[waveStage].enemies.Length;
            yield return new WaitUntil(() => ScoreSetup.killCount == killCap);
            waveStage++;
        }
    }

    IEnumerator WaveSpawn()
    {
        foreach (var enemy in waves[waveStage].enemies)
        {
            Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Length)].position, spawnPoints[Random.Range(0, spawnPoints.Length)].rotation);
            yield return new WaitForSeconds(1);
        }
    }
}

[System.Serializable]

public class Wave
{
    public GameObject[] enemies;
}