using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class EntityMovement : MonoBehaviour
{
    [Header("Range")]
    [SerializeField] private float min;
    [SerializeField] private float max;

    [Header("StopRange")]
    [SerializeField] private float stopMax;
    [SerializeField] private float stopMin;

    private Rigidbody2D rb;
    
    void Start()
    {
        var num = Random.Range(-min, -max);
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector3(0, num, 0);
    }
    
    void Update()
    {
        StopEntity();
    }

    public void StopEntity()
    {
        float stop = Random.Range(-stopMin, -stopMax);
        
        if (transform.position.y <= stop)
        {
            //Debug.Log(stop);
            rb.bodyType = RigidbodyType2D.Static;
        }
    }
}
