using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float rotaZ;
    [SerializeField] private float rotationSpeed;

    public bool ClockwiseRoation;

    private Rigidbody2D rb;

    private void Start()
    {

    }
    
    void Update()
    {
        
        /*
        if (ClockwiseRoation == false)
        {
            rotaZ += Time.deltaTime * rotationSpeed;
        }
        else
        {
            rotaZ += -Time.deltaTime * rotationSpeed;
        }
        
        transform.rotation = Quaternion.Euler(0, 0, rotaZ);
        Debug.Log(transform.rotation);
        Debug.Log(rotaZ);
        */

    }

    public void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            rotaZ += Time.deltaTime * rotationSpeed;
            obj.transform.rotation = Quaternion.Euler(0, 0, rotaZ);
        }       
    }

    public void OnTriggerExit2D(Collider2D obj)
    {
        if(obj.gameObject.tag == "Player")
        {
            obj.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

}
