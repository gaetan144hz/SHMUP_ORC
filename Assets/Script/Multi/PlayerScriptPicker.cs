using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScriptPicker : MonoBehaviour
{
    public GameObject playerSolo, player1, player2;
    private PlayerMovement playerMovement;
    private RandomSpawner randomSpawner;
    private Timer timer;
    private destroy destroyButton;

    public void Awake()
    {
        destroyButton = FindObjectOfType<destroy>();
        playerMovement = FindObjectOfType<PlayerMovement>();
        timer = FindObjectOfType<Timer>();
        randomSpawner = FindObjectOfType<RandomSpawner>();
    }
    public void Start()
    {
        if (PlayerInputManager.instance.playerCount == 1)
        {
            Instantiate(playerSolo, transform);
            randomSpawner.gameInstantiate();
            timer.timeInstantiate();
            destroyButton.destroyPress();
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
