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
    private float shieldCooldownTime;
    private bool shieldReady;
    private float doubleTapTime;

    [Header("DashImage")]
    public Image shieldImage;


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

        shieldReady = true;

        playerList.Add(this);
        playerInput = new Controllers();
        rb = GetComponent<Rigidbody2D>();
    }

    #region ShieldRegion
    public void OnShield(InputValue value)
    {
        if (value.isPressed && _pauseResume.shootStatus == true)
        {
            StartCoroutine(Shield());
            return;
        }
    }

    public IEnumerator Shield()
    {
        if (shieldReady == true)
        {
            shield.SetActive(true);
            shieldReady = false;
            StartCoroutine(ShieldCooldown());
            yield return new WaitForSeconds(5);
            shield.SetActive(false);
        }
    }

    public IEnumerator ShieldCooldown()
    {
        shieldCooldownTime = datap.currentShieldCooldown;
        shieldImage.fillAmount = 0;
        
        while (shieldCooldownTime > 0)
        {
            shieldImage.fillAmount += 1 / datap.currentShieldCooldown;
            shieldCooldownTime -= 1;
            if (shieldCooldownTime <= 0)
            {
                shieldReady = true;
                shieldImage.fillAmount = 1;
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
            if (datap.currenSpeed < datap.maxSpeed)
            {
                rb.velocity = movement * datap.currenSpeed;
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
