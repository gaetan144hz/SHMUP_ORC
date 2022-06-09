using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fps : MonoBehaviour
{
    public float pollingTime = 1f;
    public float time;
    private int frameCount;

    public TextMeshProUGUI m_Text;

    private void Start()
    {
        
    }

    private void Update()
    {
        time += Time.deltaTime;

        frameCount++;
        if(time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            m_Text.text = frameCount.ToString() + "FPS";

            time -= pollingTime;
            frameCount = 0;
        }
    }
}
