using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public int score;

    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        }
    }
    public void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        score = 10;
    }

    public void AddScore()
    {
        score += 100;
        scoreText.text = score.ToString();
    }
}
