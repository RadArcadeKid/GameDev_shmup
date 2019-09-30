﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : MonoBehaviour
{
    public float rotationsPerSecond = 0.1f;
    public bool ________________;
    public int levelShown = 0;

    // Update is called once per frame
    void Update()
    {
        // Read the current shield level from the Hero Singleton
        int currLevel = Mathf.FloorToInt( HeroScript.S.shieldLevel ); // 1

        // If this is different from levelShown...
        if (levelShown != currLevel) {
            levelShown = currLevel;

            Material mat = this.GetComponent<Renderer> ().material;
            // Adjust the texture offset to show different shield level
            mat.mainTextureOffset = new Vector2( 0.2f*levelShown, 0 ); // 2
        }

        // Rotate the shield a bit every second
        float rZ = (rotationsPerSecond*Time.time*360) % 360f; // 3
            transform.rotation = Quaternion.Euler( 0, 0, rZ );
    }   
    
}
