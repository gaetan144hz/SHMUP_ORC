using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float currentTime;
    [SerializeField] float startingTime;

    [SerializeField] TextMeshProUGUI countdownText;

    void Awake()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
    }
    
}
