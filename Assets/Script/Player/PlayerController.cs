using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float moveInput;
    public float checkRadius;

    private int extraJumps;
    public int extraJumpsValue;

    private Rigidbody2D rb;

    private bool facingRight = true;
    private bool isGrounded;

    public Transform groundCheck;

    public LayerMask whatIsGround;

    private Vector2 movementInput = Vector2.zero;
    private bool jumped = false;


    //OnMove Input to later set as Event in Input Manager
    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    //OnJump Input to later set as Event in Input Manager
    public void OnJump(InputAction.CallbackContext context)
    {
        jumped = context.action.triggered;
    }

    //start
    private void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //check if isGrounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius,whatIsGround);


        moveInput = movementInput.x;

        //Move Right/Left relative to moveInput Value (-1 till 1)
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        //rotate Player Sprite relative to a / d Input
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }

    private void Update()
    {
        // if grounded set extra jumps u can take to a preset value 
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }

        //if extrajumps is equal to 0 & player tries to jump and is grounded add upwards velocity
        if (extraJumps == 0 && jumped && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        //subtract extra jump -1 and "jump"
        else if (extraJumps > 0 && jumped)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }

    }

    //rotate player
    void Flip()
    {
        facingRight = !facingRight;

        transform.Rotate(0f, 180f, 0f);
    }
}
