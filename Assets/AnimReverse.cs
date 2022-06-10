using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimReverse : MonoBehaviour
{
    private SlideEnemyMovement entityMovement;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        entityMovement = this.GetComponent<SlideEnemyMovement>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (entityMovement.moveRight == false)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
