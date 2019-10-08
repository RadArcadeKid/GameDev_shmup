using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour
{
static public HeroScript S; // Singleton

public float gameRestartDelay = 2f; //a delay for the gameplay restart 

    // These fields control the movement of the ship
    public float speed = 10;
    public float rollMult = -45;
    public float pitchMult = 30;
    // Ship status information
    [SerializeField]
    private float _shieldLevel = 1; // Add the underscore!
    //public float shieldLevel = 1;
    public bool ____________________________;
    
    public Bounds bounds; 

    // Declare a new delegate type WeaponFireDelegate
    public delegate void WeaponFireDelegate();
    // Create a WeaponFireDelegate field named fireDelegate.
    public WeaponFireDelegate fireDelegate;

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

        // Use the fireDelegate to fire Weapons
        // First, make sure the Axis("Jump") button is pressed
        // Then ensure that fireDelegate isn't null to avoid an error
        if (Input.GetAxis("Jump") == 1 && fireDelegate != null) { // 1
            fireDelegate();
        }

    }




    // This variable holds a reference to the last triggering GameObject
    public GameObject lastTriggerGo = null; // 1

    void OnTriggerEnter(Collider other) {
        // Find the tag of other.gameObject or its parent GameObjects
        GameObject go = Utils.FindTaggedParent(other.gameObject);

        // If there is a parent with a tag
        if (go != null) {    
                // Make sure it's not the same triggering go as last time
                if (go == lastTriggerGo) { // 2
                    return;
                }
                
                lastTriggerGo = go; // 3
                if (go.tag == "Enemy") {
                        // If the shield was triggered by an enemy
                        // Decrease the level of the shield by 1
                        shieldLevel--;
                        // Destroy the enemy
                    Destroy(go); // 4
                } 
                else {
                        print("Triggered: "+go.name); // Move this line here!
                }
        } 
        else {
            // Otherwise announce the original other.gameObject
            print("Triggered: "+other.gameObject.name); // Move this line here!
        }
    }

    public float shieldLevel {
        get {
            return( _shieldLevel ); // 1
        }
        set {
            _shieldLevel = Mathf.Min( value, 4 ); // 2 (ensures the _shieldLevel is never set higher than 4)
            // If the shield is going to be set to less than zero
            if (value < 0) { // 3
                Destroy(this.gameObject);
                // Tell Main.S to restart the game after a delay
                Main.S.DelayedRestart( gameRestartDelay );
            }
        }
    }





}