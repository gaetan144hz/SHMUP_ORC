using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerMovement mover;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        var movers = FindObjectOfType<PlayerMovement>();
        var index = playerInput.playerIndex;
        //mover = movers.FirstOrDefault(m => m.GetPlayerIndex() == index);
    }
    public void OnMove(CallbackContext context)
    {
        //mover.SetInputVector(context.ReadValue<Vector2>());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
