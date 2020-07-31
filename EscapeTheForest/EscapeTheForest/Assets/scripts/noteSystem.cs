using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class noteSystem : MonoBehaviour {

    public GameObject player;
    public Text notesText;

    int NumberOfnotes;
	
	void Start () 
    {
     	
	}
	
	// Update is called once per frame
	void Update () 

    {
        NumberOfnotes = player.GetComponent<noteSpawning>().note;
        notesText.text = "Notes: " + NumberOfnotes + "/4";	
	}
}
