using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //for scene management WOW

public class ResetGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Restart", 5f); //wait 5 seconds, then restart 
    }

    public void Restart() {
        // Reload _Scene_0 to restart the game
        SceneManager.LoadScene("Main");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
