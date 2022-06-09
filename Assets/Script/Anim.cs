using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
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
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }
    }
}
