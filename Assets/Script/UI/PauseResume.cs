using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseResume : MonoBehaviour
{
    public GameObject pauseMenu;

    private GameObject player;
    private PauseInput pauseInput;
    private PlayerInput playerInput;

    public bool shootStatus;

    private void Start()
    {
        shootStatus = true;
        
        playerInput = GetComponent<PlayerInput>();
        player = GameObject.FindWithTag("Player");
        pauseInput = GetComponent<PauseInput>();
    }

    public void pause()
    {
        //pauseInput.disablePlayer();
        shootStatus = false;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resume()
    {
        //pauseInput.activePlayer();
        shootStatus = true;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        }
}
