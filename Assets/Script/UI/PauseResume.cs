using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseResume : MonoBehaviour
{
    public GameObject pauseMenu;

    private GameObject player;

    private PauseInput pauseInput;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        pauseInput = GetComponent<PauseInput>();
    }

    public void pause()
    {
        //pauseInput.disablePlayer();
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resume()
    {
        //pauseInput.activePlayer();
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void PauseResumeFunc()
    {
        if (pauseMenu.activeInHierarchy)
            resume();
        else
            pause();
    }
}
