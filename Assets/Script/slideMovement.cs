using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slideMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    private bool moveRight;
    [SerializeField] private float rangeOfSlide;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 2f;
        moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rangeOfSlide)
        {
            moveRight = false;
        }
        else if (transform.position.x < -rangeOfSlide)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
        }
    }
}
