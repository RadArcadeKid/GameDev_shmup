using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    private Transform bar; 
    public float this_enemy_max_health; 
    private float enemy_health;     

    public GameObject corrospondingEnemy; 
    public AudioSource death_sound; 

    void Start()
    {
        bar = transform.Find("Bar");
        bar.localScale = new Vector3(.4f, 1f); 
    }

    public void SetSize(float sizeNormalized){
        bar.localScale = new Vector3(sizeNormalized, 1f); 
    }

    void Update(){
        if(corrospondingEnemy == null){ //if the enemy is not on the board... 
                death_sound.Play(0); 
            SetSize(0f); //change the healthbar to zero 
        }

        else{
            enemy_health = corrospondingEnemy.GetComponent<EnemyScript>().GetHealth(); //retrieve the health from this enemy's script 
            SetSize( (enemy_health/this_enemy_max_health) );  //pass in the enemyHealth into the SetSize function, thus triggering the healthbar
 
        }
    } 
}
