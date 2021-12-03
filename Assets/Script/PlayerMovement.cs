using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    public int bulletDamage = 20;

    private Controllers playerInput; // recupere le Input Action, attention au nom

    private Rigidbody2D rb;
    
    //public int bulletSpeed = 3;
    //public int playerDamage = 40;

    public float speed = 10f;

    void Awake()
    {
        playerInput = new Controllers();
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        //récupérer l'action maps (**player**) puis l'Action (**move**) dans l'input action ATTENTION AU NOM !!!
        Vector2 moveInput = playerInput.player.move.ReadValue<Vector2>();
        rb.velocity = moveInput * speed;
    }
}
