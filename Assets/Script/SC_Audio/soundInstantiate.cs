using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundInstantiate : MonoBehaviour
{
    public GameObject sounds;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Instantiate(sounds, transform.position, transform.rotation);
        }
    }
}
