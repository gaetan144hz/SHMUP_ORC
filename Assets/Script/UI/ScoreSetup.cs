using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class ScoreSetup : MonoBehaviour
{
    //rangement TMPro
    public TextMeshProUGUI dmgScore;
    public TextMeshProUGUI killScore;
    //rangement des int, float, string, bool, etc...
    public int dmgCount;
    public int killCount;

    void Awake()
    {
        dmgCount = 0;
        killCount = 0;
    }

    public void AddDmgScore(int scoreToAdd) //Fonction pour compter les dégats !
    {
        dmgCount += scoreToAdd;
        dmgScore.text = $"dmg: {dmgCount}";
    }

    public void AddKillScore(int killToAdd)
    {
        killCount += killToAdd;
        killScore.text = $"kill: {killCount}";
    }
}