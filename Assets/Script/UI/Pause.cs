using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenu;

    public void OnResume(InputValue value)
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;              
        GameIsPaused = false;
    }

    public void OnPause(InputValue value)
    {
        pauseMenu.SetActive(true);        
        Time.timeScale = 0f;        
        GameIsPaused = true;
    }
}
