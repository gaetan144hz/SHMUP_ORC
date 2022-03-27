using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slime : MonoBehaviour
{
    [SerializeField] private float rotaZ;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private int timeToDestroy;

    public bool ClockwiseRoation;

    private Rigidbody2D rb;

    private void Start()
    {
        Destroy(this.gameObject, timeToDestroy);
    }
    
    void Update()
    {
        rotaZ += Time.deltaTime * rotationSpeed;
    }

    public void OnTriggerStay2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {            
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
