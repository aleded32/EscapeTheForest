using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreSystem : MonoBehaviour {


    int currentScore;
    public GameObject player;
    public Text scoreText;
	// Use this for initialization
	void Start () {

        currentScore = 0;
	}
	
	// Update is called once per frame
	void Update () {


        currentScore = (int)player.transform.position.x;
        scoreText.text = "Score: " + currentScore;
	}
}
