using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float rotaZ;
    [SerializeField] private float rotationSpeed;
    public bool ClockwiseRoation;

    /*
    private void Start()
    {
        rotaZ += Time.deltaTime * rotationSpeed;
        transform.rotation = Quaternion.Euler(0, 0, rotaZ);
    }
    */

    void Update()
    {
        
        if (ClockwiseRoation == false)
        {
            rotaZ += Time.deltaTime * rotationSpeed;
        }
        else
        {
            rotaZ += -Time.deltaTime * rotationSpeed;
        }

        transform.rotation = Quaternion.Euler(0, 0, rotaZ);
        
    }
        
}
