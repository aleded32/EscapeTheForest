using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScreenChange : MonoBehaviour {

    float time = 1.8f;
    
    
    
    // Update is called once per frame
    void Update ()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            SceneManager.LoadScene("GameScreen");
            Debug.Log("2");
            time = 0;
        }

        

	}
}
