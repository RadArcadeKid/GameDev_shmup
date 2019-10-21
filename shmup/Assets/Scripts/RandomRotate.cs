using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{

    public Quaternion qTo;
    public float rotateSpeed = 3.0f;
    public float timer = 0.0f;
    
    void Start() {
    qTo = Quaternion.Euler(new Vector3(0f, 0f, Random.Range(-60.0f, 60.0f))); //declare a single rotation Quaternion up here because it only needs it once 
    }
    
    void Update() {
    
        timer += Time.deltaTime;
    
            if(timer > 2f) { //timer should reset at 2 seconds, thus rotating 
                qTo = Quaternion.Euler(new Vector3(0f, 0f, Random.Range(-60.0f, 60.0f)));
                timer = 0.0f;
            }
            transform.rotation = Quaternion.Slerp(transform.rotation, qTo, Time.deltaTime * rotateSpeed); //transform to the target rotation using slerp!! 
            //transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }    
}
