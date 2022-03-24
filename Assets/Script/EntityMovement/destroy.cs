using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    [SerializeField] float timeToDestroy;

    public void update()
    {
        Destroy(this.gameObject,timeToDestroy);
    }
}
