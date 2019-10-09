using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : MonoBehaviour
{
    //  public float speed = 1.0f;
    //  public float y = 27.3f; 
    //  private Vector3 pos1;
    //  private Vector3 pos2;
    //  private Vector3 current_pos; 

    //  void Start(){
    //     InvokeRepeating("ChangePos", 0f, speed);
    //  }

    //  void Update() {
    //     current_pos = transform.position; 
    //     // transform.position = Vector3.Lerp (pos1, pos2, Mathf.PingPong(Time.time*speed, 0.0f));

    //     transform.position = Vector3.Lerp (transform.position, pos2, (Mathf.Sin(speed * Time.time)));
    //  }

      
    // //updates the position 
    //  void ChangePos(){
    //     // pos1 =  new Vector3(Random.Range(-20.0f, 20.0f), y, 0); 
    //     pos1 =  new Vector3(Random.Range(-20.0f, 20.0f), y, 0); 

    //     pos2 =  new Vector3(Random.Range(-20.0f, 20.0f), y, 0);

    //  }

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

