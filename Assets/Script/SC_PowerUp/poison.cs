using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class poison : MonoBehaviour
{
    public PlayerData datap;
    private PlayerHealth playerHealth;

    [SerializeField] private int timeToDestroy;

    [SerializeField] public float poisonIncrease;

    private Animator animator;
    
    [Header("Audio")] 
    public AudioClip sound;
    public AudioSource source;

    private Rigidbody2D rb;
    private bool isCoroutine;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
        
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        source.clip = sound;
        source.Play();
        
        playerHealth = FindObjectOfType<PlayerHealth>();
        
        rb.gravityScale = 0;

        Destroy(this.gameObject,timeToDestroy);
        isCoroutine = false;
    }

    private void Update()
    {
        if (rb.velocity.y == 0)
        {
            animator.SetBool("toFl4k", true);
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player" && isCoroutine == false)
        {
            StartCoroutine(MakePoison());
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            isCoroutine = false;
        }
    }

    public IEnumerator MakePoison()
    {
        isCoroutine = true;

        while (isCoroutine == true)
        {
            playerHealth.TakeDamage(poisonIncrease);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
