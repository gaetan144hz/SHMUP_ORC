using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectDestroy : MonoBehaviour
{
    public float timeToDestroy;
    
    void Start()
    {
        Destroy(this.gameObject, timeToDestroy);
    }

    void Update()
    {
        
    }
}
