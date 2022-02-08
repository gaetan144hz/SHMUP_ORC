using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class EntityMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    void Start()
    {
        var num = Random.Range(-1, -10);
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector3(0, num, 0);
    }
    
    void Update()
    {
        StopEntity();
    }

    public void StopEntity()
    {
        float stop = Random.Range(4, 9);
        
        if (transform.position.y <= -stop)
        {
            //Debug.Log(stop);
            rb.bodyType = RigidbodyType2D.Static;
        }
    }
}
