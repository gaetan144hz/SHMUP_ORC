using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    public GameObject winCanvas;

    public GameObject boss;

    private void Start()
    {
        boss = GameObject.FindWithTag("Boss");
    }
    public void timeScale()
    {
        winCanvas.SetActive(false);
        Time.timeScale = 1f;
        Destroy(boss.gameObject);
    }
}
