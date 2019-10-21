using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceShuffle : MonoBehaviour
{

        public float speed = 1.0f;
    public float xPos;
    public float xRange = 2f; 
    public float yPos; 
    public float yRange = 2f;

    public Vector3 desiredPos;
    public float cutoff_value = 1.0f; //determines how long the object will stay at this point 


    void Start()
    {
        desiredPos = new Vector3(transform.position.x, transform.position.y, 0);
    }
 
    void Update()
    {
             transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);

    }

}
