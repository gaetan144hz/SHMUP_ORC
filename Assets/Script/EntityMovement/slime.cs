using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class slime : MonoBehaviour
{
    [SerializeField] private float rotaZ;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private int timeToDestroy;

    private Animator animator;
    private Rigidbody2D rb;
    
    public bool ClockwiseRoation;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody2D>();
        
       Destroy(this.gameObject, timeToDestroy);
    }
    
    void Update()
    {
        rotaZ += Time.deltaTime * rotationSpeed;

        if (rb.velocity.y == 0)
        {
            animator.SetBool("toFl4k", true);
        }
    }

    public void OnTriggerStay2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {            
            Gamepad.current.SetMotorSpeeds(0.5f,0.5f);
            obj.transform.rotation = Quaternion.Euler(0, 0, rotaZ);
        }
    }

    public void OnTriggerExit2D(Collider2D obj)
    {
        if(obj.gameObject.tag == "Player")
        {
            obj.transform.rotation = Quaternion.Euler(0, 0, 0);
            Gamepad.current.SetMotorSpeeds(0f,0f);
        }
    }
}
