using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip[] sound;
    private AudioSource source;
    
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("playerBullet"))
        {
            source.clip = sound[0];
            source.Play();
        }
    }
}
