using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScriptPicker : MonoBehaviour
{
    public GameObject playerSolo, player1, player2;
    private PlayerMovement playerMovement;
    private RandomSpawner randomSpawner;
    private Timer timer;

    public void Start()
    { 
        playerMovement = FindObjectOfType<PlayerMovement>();
        timer = FindObjectOfType<Timer>();
        randomSpawner = FindObjectOfType<RandomSpawner>();

        if (PlayerInputManager.instance.playerCount == 1)
        {
            Instantiate(playerSolo, transform);
            randomSpawner.gameInstantiate();
            timer.timeInstantiate();
        }
        else
        {
            var solo = FindObjectOfType<PlayerMovement>().transform;
            var soloPosition = solo.position;
            var soloParent = solo.parent;
            PlayerMovement.playerList.Remove(playerMovement);
            Destroy(solo.gameObject);
            Instantiate(player1, soloPosition, quaternion.identity ,soloParent);
            Instantiate(player2, transform);
        }
    }
}
