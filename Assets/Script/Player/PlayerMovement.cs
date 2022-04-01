using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using TMPro;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    [Header("Data")]
    public PlayerData datap;
    
    [Header("Dash")]
    private float dashCooldownTime;
    private bool dashReady;

    public Animator animator;

    public static List<PlayerMovement> playerList = new List<PlayerMovement>();
    public static List<PlayerMovement> GetPlayerList()
    {
        return playerList;
    }

    private Controllers playerInput; // recupere le Input Action, attention au nom
    private Rigidbody2D rb;

    void Awake()
    {
        datap = Instantiate(datap);

        dashReady = true;
        
        playerList.Add(this);
        playerInput = new Controllers();
        rb = GetComponent<Rigidbody2D>();
    }

    #region DashRegion
    public void OnDashR(InputValue value)
    {
        if (value.isPressed)
        {
            if (dashReady == false)
            {
                return;
            }
            dashReady = false;
            StartCoroutine(DashCooldown());
            Debug.Log("RightDashReady True");
            rb.AddForce(transform.right * datap.currentSpeedDash);
        }
    }
    public void OnDashL(InputValue value)
    {
        if (value.isPressed)
        {
            if (dashReady == false)
            {
                return;
            }
            dashReady = false;
            StartCoroutine(DashCooldown());
            Debug.Log("LeftDashReady True");
            rb.AddForce(-transform.right * datap.currentSpeedDash);
        }
    }

    public IEnumerator DashCooldown()
    {
        dashCooldownTime = datap.currentDashCooldown;
        
        while (dashCooldownTime > 0)
        {
            dashCooldownTime -= 1;
            if (dashCooldownTime <= 0)
            {
                dashReady = true;
            }
            else
            {
                yield return new WaitForSeconds(1);
            }
        }
    }
    #endregion


    #region Movement
    public void OnMove(InputValue value)
    {
        //récupérer l'action maps (**player**) puis l'Action (**move**) dans l'input action ATTENTION AU NOM !!!
        //Vector2 moveInput = playerInput.player.move.ReadValue<Vector2>();

        Vector2 moveInput = value.Get<Vector2>().normalized;

        bool isIdle = moveInput.x == 0 && moveInput.y == 0;
        if (isIdle)
        {
            rb.velocity = Vector2.zero;
            animator.SetBool("isMoving", false);
        }
        else
        {
            rb.velocity = moveInput * datap.speed;

            animator.SetFloat("horizontalMovement", moveInput.x);
            animator.SetFloat("horizontalMovement", moveInput.y);
            animator.SetBool("isMoving", true);
        }
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }
    #endregion
}
