using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManagerScene : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject settingsMenuUI;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1.0f;
    }

    public void Options()
    {
        settingsMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        pauseMenuUI.SetActive(false);

        if(settingsMenuUI == false)
        {
            pauseMenuUI.SetActive(true);
        }
    }

    public void Credit()
    {
        Debug.Log("Quentin, Gaetan + 7Anims lol");
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
        Debug.Log("Jeu Quitté");
    }

    public void PauseGame(InputAction.CallbackContext ctx)
    {
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Paused();
        }
    }

    public void Resume()
    {
        player.SetActive(true);
        pauseMenuUI.SetActive(false);
        settingsMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GameIsPaused = false; 
    }

    public void Paused()
    {
        player.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
