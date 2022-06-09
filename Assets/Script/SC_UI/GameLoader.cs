using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    private PlayerMovement playerMovement;
    
    public void LevelLoader()
    {
        SceneManager.LoadScene(2);
        playerMovement = FindObjectOfType<PlayerMovement>();
        OnDestroy();
    }
    
    
    private void OnDestroy()
    {
        PlayerMovement.playerList.Remove(playerMovement);
    }
}
