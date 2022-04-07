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
    public TextMeshProUGUI textCooldownDash;

    [Header("DashImage")]
    public Image dashImage;
    public GameObject RcButton;


    [Header("Shied")]
    public GameObject shield;

    public Animator animator;
    private PauseResume _pauseResume;

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
            rb.AddForce(movement * datap.currentSpeedDash, ForceMode2D.Impulse);
            yield return new WaitForSeconds(0.5f);
            shield.SetActive(false);
        }
    }

    public IEnumerator DashCooldown()
    {
        dashCooldownTime = datap.currentDashCooldown;
        dashImage.fillAmount = 0;
        
        while (dashCooldownTime > 0)
        {
            textCooldownDash.text = dashCooldownTime.ToString("0");
            dashImage.fillAmount += 1 / datap.currentDashCooldown;
            dashCooldownTime -= 1;
            if (dashCooldownTime <= 0)
            {
                dashReady = true;
                textCooldownDash.text = " ";
                RcButton.SetActive(true);
                dashImage.fillAmount = 1;
            }
            else
            {
                RcButton.SetActive(false);
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
