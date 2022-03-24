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

    private ScoreSetup ScoreSetup;
    private RandomDisqueSpawner randomDisqueSpawner;

    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public GameObject wavesObject;
    public TextMeshProUGUI wavesText;
    public Animator animator;

    private Timer timer;

    public void Start()
    {
        randomDisqueSpawner = FindObjectOfType<RandomDisqueSpawner>();
        ScoreSetup = FindObjectOfType<ScoreSetup>();
        timer = FindObjectOfType<Timer>();
    }

    public void gameInstantiate()
    {
        StartCoroutine(Spawn());
    }

    private void Update()
    {
        //wave1();
    }

    /*
    public void goblinToTank()
    {
        int randEnemy = Random.Range(0, 2);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
    }

    public void onlyGoblin()
    {
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyPrefabs[0], spawnPoints[randSpawnPoint].position, transform.rotation);
        Debug.Log(enemyPrefabs[0]);
    }
    */
    

    public void wave(int enemyValue, int spawnValue)
    {
        Instantiate(enemyPrefabs[enemyValue], spawnPoints[spawnValue].position, spawnPoints[spawnValue].rotation);
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            wavesText.text = "WAVE 1";
            wavesObject.SetActive(true);
            animator.Play("Anim_WaveText");
            yield return new WaitForSeconds(1);
            wavesObject.SetActive(false);

            wavesText.text = "START !";
            wavesObject.SetActive(true);
            animator.Play("Anim_WaveText");
            yield return new WaitForSeconds(1);
            wavesObject.SetActive(false);

            wave(0, 2);
            yield return new WaitUntil(() => ScoreSetup.killCount == 1);

            wavesText.text = "WAVE 2";
            wavesObject.SetActive(true);
            animator.Play("Anim_WaveText");
            yield return new WaitForSeconds(1);
            wavesObject.SetActive(false);

            wavesText.text = "START !";
            wavesObject.SetActive(true);
            animator.Play("Anim_WaveText");
            yield return new WaitForSeconds(1);
            wavesObject.SetActive(false);

            randomDisqueSpawner.disqueInstantiate();
            wave(Random.Range(0, enemyPrefabs.Length), 2);
            wave(Random.Range(0, enemyPrefabs.Length), 3);
            yield return new WaitUntil(() => ScoreSetup.killCount == 3);

            wavesText.text = "WAVE 3";
            wavesObject.SetActive(true);
            animator.Play("Anim_WaveText");
            yield return new WaitForSeconds(1);
            wavesObject.SetActive(false);

            wavesText.text = "START !";
            wavesObject.SetActive(true);
            animator.Play("Anim_WaveText");
            yield return new WaitForSeconds(1);
            wavesObject.SetActive(false);

            wave(Random.Range(0, enemyPrefabs.Length), 0);
            wave(Random.Range(0, enemyPrefabs.Length), 1);
            wave(Random.Range(0, enemyPrefabs.Length), 3);
            yield return new WaitUntil(() => ScoreSetup.killCount == 6);

            Debug.Log("WAVE 3 END");

            yield return new WaitUntil(() => timer.currentTime >= 20);
            Debug.Log("Boss");
            yield return false;
        }
    }
}