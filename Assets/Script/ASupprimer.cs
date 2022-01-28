using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ASupprimer : MonoBehaviour
{

    private List<ScoreClass> recordedScores = new List<ScoreClass>();

    // Start is called before the first frame update
    void Start()
    {
        recordedScores.Add(new ScoreClass());
        recordedScores.Add(new ScoreClass());
        recordedScores.Add(new ScoreClass());
        recordedScores.Add(new ScoreClass());
        recordedScores.Add(new ScoreClass());
        recordedScores.Add(new ScoreClass());
        recordedScores.Add(new ScoreClass());

        recordedScores = recordedScores.OrderByDescending(scoreClass => scoreClass.score).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int time, int score)
    {
        recordedScores.Add(new ScoreClass(time, score));

        recordedScores = recordedScores.OrderByDescending(scoreClass => scoreClass.score).ToList();

    }
}

public class ScoreClass
{
    public int time;
    public int score;
    public string name;

    public ScoreClass()
    {
        time = Random.Range(100, 360);
        score = Random.Range(2000, 5000);
    }

    public ScoreClass(int newTime, int newScore)
    {
        time = newTime;
        score = newScore;
    }
}
