using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    [SerializeField] private float timeToDestroy; 

    private void Update()
    {
        Destroy(this.gameObject,timeToDestroy);
    }
}
