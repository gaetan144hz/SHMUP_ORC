using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeMutant : MonoBehaviour
{
    public Quaternion startQuaternion;
    public float lerpTime = 1;
    public float RotateAmount ;

    public bool rotate;
    public bool rotateConstantly;
    
    void Start()
    {
        startQuaternion = transform.rotation;
    }
    
    void Update()
    {
        if (rotate)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, startQuaternion,Time.deltaTime * lerpTime );
            //transform.rotation = Quaternion.Euler(0, 0, 180);
        }

        if (rotateConstantly)
        {
            //transform.rotation = Quaternion.Euler(0, 0, 180);
            transform.Rotate(Vector3.up * RotateAmount);
        }
    }

    public void snapRotation()
    {
        transform.rotation = startQuaternion;
    }
}
