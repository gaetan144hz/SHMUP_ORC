using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float sec;
    public float min;
    public float currentTime;
    [SerializeField] float startingTime;

    [SerializeField] TextMeshProUGUI countdownText;

    void Awake()
    {
        sec = startingTime;
    }

    public void timeInstantiate()
    {
        StartCoroutine(timeCount());
    }

    IEnumerator timeCount()
    {
        sec = 0;
        min = 0;
        currentTime = 0;

        while(true)
        {
            sec += 1;
            currentTime += 1;
            if (sec >= 60)
            {
                sec = 0;
                min += 1;
            }
            if (sec <= 9)
            {
                countdownText.text = $"{min}:0{sec}";
            }
            else
            {
                countdownText.text = $"{min}:{sec}";
            }
            yield return new WaitForSeconds(1);
        }
    }
}
