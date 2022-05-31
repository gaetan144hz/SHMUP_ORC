using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    [Header("Data")]
    public PlayerData datap;
    
    [Header("Dash")]
    private float dashCooldownTime;
    private bool dashReady;
    private float doubleTapTime;

    [Header("DashImage")]
    public Image dashImage;


    [Header("Shied")]
    public GameObject shield;

    public Animator animator;
    private PauseResume _pauseResume;

    private Controllers playerInput; // recupere le Input Action, attention au nom
    private Vector2 movement;
    private Vector2 lastMovement;
    private Rigidbody2D rb;
    
    public static List<PlayerMovement> playerList = new List<PlayerMovement>();
    public static List<PlayerMovement> GetPlayerList()
    {
        return playerList;
    }

    void Awake()
    {
        _pauseResume = FindObjectOfType<PauseResume>();
        datap = Instantiate(datap);

        dashReady = true;

        playerList.Add(this);
        playerInput = new Controllers();
        rb = GetComponent<Rigidbody2D>();
        lastMovement = Vector2.up;
    }

    #region DashRegion
    public void OnDashR(InputValue value)
    {
        if (value.isPressed && _pauseResume.shootStatus == true)
        {
            StartCoroutine(Dash());
            return;
        }
    }

    public IEnumerator Dash()
    {
        if (dashReady == true)
        {
            shield.SetActive(true);
            dashReady = false;
            StartCoroutine(DashCooldown());
            rb.AddForce(lastMovement * datap.currentSpeedDash, ForceMode2D.Impulse);
            yield return new WaitForSeconds(0.5f);
            rb.velocity = Vector2.zero;
            shield.SetActive(false);
        }
    }

    public IEnumerator DashCooldown()
    {
        dashCooldownTime = datap.currentDashCooldown;
        dashImage.fillAmount = 0;
        
        while (dashCooldownTime > 0)
        {
            dashImage.fillAmount += 1 / datap.currentDashCooldown;
            dashCooldownTime -= 1;
            if (dashCooldownTime <= 0)
            {
                dashReady = true;
                dashImage.fillAmount = 1;
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

        if (movement != Vector2.zero)
        {
            lastMovement = movement; 
        }

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
