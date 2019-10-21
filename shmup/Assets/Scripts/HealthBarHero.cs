using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarHero : MonoBehaviour
{

    private Transform bar; 
    public float hero_max_health; 
    private float hero_health;     

    public GameObject hero_obj; 

    void Start()
    {
        bar = transform.Find("Bar");
        bar.localScale = new Vector3(.4f, 1f); 
    }

    public void SetSize(float sizeNormalized){
        bar.localScale = new Vector3(sizeNormalized, 1f); 
    }

    void Update(){
        if(hero_obj == null){ //if the enemy is not on the board... 
        
            SetSize(0f); //change the healthbar to zero 
        }

        else{
            hero_health = hero_obj.GetComponent<HeroScript>().GetHealth(); //retrieve the health from this enemy's script 
            SetSize( (hero_health/hero_max_health) );  //pass in the enemyHealth into the SetSize function, thus triggering the healthbar
        }
    } 
}
