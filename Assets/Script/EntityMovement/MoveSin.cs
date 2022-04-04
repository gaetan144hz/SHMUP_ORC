using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSin : MonoBehaviour
{
    private float sinCenterY;
    [SerializeField] private float amplitude;
    [SerializeField] private float frequency;

    public bool inverted = false;

    private void Start()
    {
        sinCenterY = transform.position.y;
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(pos.x * frequency) * amplitude;
        if (inverted)
        {
            sin *= -1;
        }
        pos.y = sinCenterY + sin;

        transform.position = pos;
    }
}
