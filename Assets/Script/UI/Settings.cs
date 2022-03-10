using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public Menu menu;
    
    public void onSettings()
    {
        menu = FindObjectOfType<Menu>();
        menu.loadSave();
        SceneManager.LoadScene(3); //Settings
    }
}
