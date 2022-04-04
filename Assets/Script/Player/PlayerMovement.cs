using System;
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
    
    private Controllers playerInput; // recupere le Input Action, attention au nom
    private Vector2 movement;
    private Rigidbody2D rb;
    
    public static List<PlayerMovement> playerList = new List<PlayerMovement>();
    public static List<PlayerMovement> GetPlayerList()
    {
        return playerList;
    }
    
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
            Debug.Log("DASH");
            rb.AddForce(movement * datap.currentSpeedDash);
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
    private void OnMove(InputValue value)
    {
        //récupérer l'action maps (**player**) puis l'Action (**move**) dans l'input action ATTENTION AU NOM !!!
        //Vector2 moveInput = playerInput.player.move.ReadValue<Vector2>();

        movement = value.Get<Vector2>();
        
        bool isIdle = movement.x == 0 && movement.y == 0;
        if (isIdle)
        {
            rb.velocity = Vector2.zero;
            animator.SetBool("isMoving", false);
        }
        else
        {
            if (datap.speed < datap.maxSpeed)
            {
                rb.velocity = movement * datap.speed;
            }
            animator.SetFloat("horizontalMovement", movement.x);
            animator.SetFloat("horizontalMovement", movement.y);
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
