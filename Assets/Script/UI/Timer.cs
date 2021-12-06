using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class Timer : MonoBehaviour
{
    [SerializeField] float currentTime = 0f;
    [SerializeField] float startingTime = 0f;

    [SerializeField] TextMeshProUGUI countdownText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime == 5)
        {
            currentTime = 0;
            Time.timeScale = 0f;
            countdownText.color = Color.red;
        }
    }
}
