using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTurnAround : MonoBehaviour
{
    public GameObject target;
    [SerializeField] private int angle;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.back, angle * Time.deltaTime);
    }
}
