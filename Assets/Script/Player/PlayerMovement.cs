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
    public TextMeshProUGUI textCooldownDash;

    [Header("DashImage")]
    public Image dashImage;

    public Animator animator;
    private PauseResume _pauseResume;

    private Vector2 lastMovement;

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
        _pauseResume = FindObjectOfType<PauseResume>();
        datap = Instantiate(datap);

        dashReady = true;

        playerList.Add(this);
        playerInput = new Controllers();
        rb = GetComponent<Rigidbody2D>();

        lastMovement = new Vector2(0, 1);
    }

    void Update()
    {
        if (movement != Vector2.zero)
        {
            lastMovement = movement;
        }
    }

    #region DashRegion
    public void OnDashR(InputValue value)
    {
        if (value.isPressed && _pauseResume.shootStatus == true)
        {
            Dash();
            return;
        }
        else
        {
            return;
        }
    }

    public void Dash()
    {
        if (dashReady == false)
        {
            return;
        }
        dashReady = false;
        StartCoroutine(DashCooldown());
        rb.AddForce(lastMovement * datap.currentSpeedDash);
    }

    public IEnumerator DashCooldown()
    {
        dashCooldownTime = datap.currentDashCooldown;
        dashImage.fillAmount = 0;
        
        while (dashCooldownTime > 0)
        {
            textCooldownDash.fontSize = 32;
            textCooldownDash.text = dashCooldownTime.ToString("0");
            dashImage.fillAmount += 1 / datap.currentDashCooldown;
            dashCooldownTime -= 1;
            if (dashCooldownTime <= 0)
            {
                dashReady = true;
                textCooldownDash.fontSize = 14;
                textCooldownDash.text = "SHIFT";
                dashImage.fillAmount = 1;
            }
            else
            {
                textCooldownDash.fontSize = 32;
                textCooldownDash.text = dashCooldownTime.ToString("0");
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
