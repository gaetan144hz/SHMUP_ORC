using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class ScoreSetup : MonoBehaviour
{
    //rangement TMPro
    public TextMeshProUGUI dmgScore;
    //rangement des int, float, string, bool, etc...
    public int dmgCount;

    void Awake()
    {
        dmgCount = 0;
    }

    public void OnSelected()
    {
        Debug.Log("marche");
    }

    public void AddDmgScore(int scoreToAdd) //Fonction pour compter les dégats !
    {
        dmgCount += scoreToAdd;
        dmgScore.text = $"dmg: {dmgCount}";
    }
}