using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBasedOnAudio : MonoBehaviour
{
	//public float size = 10.0f;
	//public float amplitude = 1.0f;
	//public int cutoffSample = 128; //MUST BE LOWER THAN SAMPLE SIZE

    public GameObject enemyToSpawnObjectFrom; //this will be the object the enemy spawns with
	public FFTWindow fftWindow;
    public float SpawnThreshold = 0.5f;
    public int frequency = 0; 
	//public float debug_val; 

	public AudioSource this_audiosource; 
	
	private float[] samples = new float[1024]; //MUST BE A POWER OF TWO
	//private LineRenderer lineRenderer;
	//private float stepSize;

	void Start()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		this_audiosource.GetSpectrumData(samples,0,fftWindow);
        
		//debug_val = samples[frequency];
        if(samples[frequency] > SpawnThreshold){
            enemyToSpawnObjectFrom.GetComponent<EnemyScript>().Fire(); //fire the projectile once the audio reaches this treshold
        }

	}
}

