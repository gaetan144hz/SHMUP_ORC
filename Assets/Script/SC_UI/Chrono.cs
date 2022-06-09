using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chrono : MonoBehaviour
{
    PlayerHealth playerHealthScript;

    GameObject player;

    public TextMeshProUGUI chronoText;

    [SerializeField] float chronometre = 60;
    private void Awake()
    {
        playerHealthScript = GetComponent<PlayerHealth>();
    }
    void Update()
    {
        chronoFonction();
        stop();
    }

    public void stop()
    {
        if(player)
        {
            Time.timeScale = 0f;
        }
    }

    public void chronoFonction()
    {
        chronometre = chronometre + Time.deltaTime;
        chronoText.text = chronometre.ToString();
    }
}
