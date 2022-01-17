using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(transform.forward * 10, ForceMode2D.Impulse);
    }

    void Update()
    {
        
    }
}
