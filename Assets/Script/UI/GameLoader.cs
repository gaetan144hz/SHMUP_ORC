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
        var solo = FindObjectOfType<PlayerMovement>().transform;
        OnDestroy();
    }
    
    
    private void OnDestroy()
    {
        PlayerMovement.playerList.Remove(playerMovement);
    }
}
