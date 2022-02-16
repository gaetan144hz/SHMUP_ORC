using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    [SerializeField] private int timeToDestroy; 

    private void Update()
    {
        Destroy(this.gameObject,timeToDestroy);
    }
}
