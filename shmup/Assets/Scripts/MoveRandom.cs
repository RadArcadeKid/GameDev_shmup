using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : MonoBehaviour
{

    public float speed = 1.0f;
    public float xPos;
    public float xRange = 10.0f; 

    public Vector3 desiredPos;
    public float cutoff_value = 1.0f; //determines how long the object will stay at this point 

    void Start()
    {
         xPos = Random.Range((xRange * -1.0f), xRange);
         desiredPos = new Vector3(xPos, transform.position.y, 0);
    }
 
    void Update()
    {
             transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);
             
             if (Vector3.Distance(transform.position, desiredPos) <= cutoff_value)
             {
                 xPos = Random.Range((xRange * -1.0f), xRange);
                 desiredPos = new Vector3(xPos, transform.position.y, 0);
             }

    }
}

