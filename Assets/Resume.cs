using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public GameObject pauseMenu;

    public void OnResume()
    {
        pauseMenu.SetActive(false);
    }
}
