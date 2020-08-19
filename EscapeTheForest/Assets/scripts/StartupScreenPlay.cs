using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupScreenPlay : MonoBehaviour {


    public GameObject mainMenuUI;
    public Animator animator;
    private bool isPopScreenPlayed = false;
    float timePopup = 0.004f;

	// Use this for initialization
	void Start ()
    {
        
	}

    // Update is called once per frame
    void Update()
    {
        if (isPopScreenPlayed == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("isPressed", true);
                InvokeRepeating("setStartMenuActive", 1, 1);
            }

            Debug.Log(timePopup);
        }
    }


    void setStartMenuActive()
    {
        timePopup -= Time.deltaTime;
        animator.SetBool("isPressed", false);
        if (timePopup < 0.004f && timePopup > 0.001f) 
        {
            mainMenuUI.SetActive(false);
        }
        if (timePopup < 0)
        {
            isPopScreenPlayed = true;
            mainMenuUI.SetActive(true);
           timePopup = 0;            
           CancelInvoke("setStartMenuActive");
           
        }
    }
}
