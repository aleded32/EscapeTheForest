using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupScreenPlay : MonoBehaviour {


    public GameObject mainMenuUI;
    float timePopup = 0.4f;

	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {

        InvokeRepeating("setStartMenuActive", 1, 1);
        Debug.Log(timePopup);
	}


    void setStartMenuActive()
    {
        timePopup -= Time.deltaTime;

        if (timePopup < 0.4f && timePopup > 0.01f) 
        {
            mainMenuUI.SetActive(false);
        }
        else if (timePopup <= 0)
        {
            mainMenuUI.SetActive(true);
           // time = 0;            
            CancelInvoke("setStartMenuActive ");
           
        }
    }
}
