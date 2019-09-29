using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour
{
static public HeroScript S; // Singleton

    // These fields control the movement of the ship
    public float speed = 30;
    public float rollMult = -45;
    public float pitchMult = 30;
    // Ship status information
    public float shieldLevel = 1;
    public bool ____________________________;
    
    public Bounds bounds; 

    void Awake() {
        S = this; // Set the Singleton
        bounds = Utils.CombineBoundsOfChildren(this.gameObject); //set the bounds (with combined bounds of children )
    }
    void Update () {
        // Pull in information from the Input class
        float xAxis = Input.GetAxis("Horizontal"); // 1
        float yAxis = Input.GetAxis("Vertical"); // 1

        // Change transform.position based on the axes
        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.position = pos;

        bounds.center = transform.position; // 1
        
        // Keep the ship constrained to the screen bounds
        Vector3 off = Utils.ScreenBoundsCheck(bounds, BoundsTest.onScreen); // 2
        if ( off != Vector3.zero ) { // 3
            pos -= off;
            transform.position = pos;
        }

        // Rotate the ship to make it feel more dynamic // 2
        transform.rotation = Quaternion.Euler(yAxis*pitchMult,xAxis*rollMult,0);
    }
}