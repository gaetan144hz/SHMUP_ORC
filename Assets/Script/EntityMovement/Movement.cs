using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D rb;

    void Start()
    {
        Vector3 pos = transform.position;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        
    }
}
