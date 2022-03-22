using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;

    private GameObject pauseMenu;

    public void Awake()
    {
        pauseMenu = GameObject.Find("PauseMenu");
        pauseMenu.SetActive(false);
    }

    public void OnResume(InputValue value)
    {
        if (value.isPressed)
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
    }

    public void OnPause(InputValue value)
    {
        if (value.isPressed)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }
}
