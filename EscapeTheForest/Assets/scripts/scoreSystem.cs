using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreSystem : MonoBehaviour {


   
    public GameObject player;
    public Text scoreText;
    

    public int currentScore = 0;
    float timeInterval;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    private void Update()
    {
        timeInterval += Time.deltaTime;
        if (timeInterval >= 0.25 && player.transform.position.x >= 1) 
        {
            currentScore++;
            timeInterval = 0;
        }
      


       


        scoreText.text = "Score: " +  currentScore;


    }

   
	

   
}
