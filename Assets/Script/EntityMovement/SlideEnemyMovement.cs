using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideEnemyMovement : MonoBehaviour
{
    [Header("EnemyData")]
    public EnemyData data;

    public bool moveRight;

    [Header("Range")]
    [SerializeField] private float rangeRight;
    [SerializeField] private float rangeLeft;

    // Start is called before the first frame update
    void Start()
    {
        //moveSpeed = 2f;
        moveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > rangeRight)
        {
            moveRight = false;
        }
        else if (transform.position.x < rangeLeft)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + data.currentSpeedMovement * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - data.currentSpeedMovement * Time.deltaTime, transform.position.y);
        }
    }
}
