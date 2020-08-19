using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollUpgradesMenu : MonoBehaviour {

    public GameObject up;
    public GameObject down;
    public GameObject upgradeTree;
    public GameObject upgradeMenu;
    public bool isUpPressed = false;
    public bool isDownPressed = false;
   


    public Animator animator;
    public Animator animatorBack;
    public Animator animatorUpgradeText;
    

	void Start ()
    {
        up.SetActive(false);
        down.SetActive(true);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isUpPressed == true)
        {
            up.SetActive(false);
            animatorUpgradeText.Play("moveDownText2");
            animatorBack.Play("moveUpText");
            animator.Play("MoveDown");  
            isUpPressed = false;
            down.SetActive(true);


        }
        else if (isDownPressed == true)
        {
            
            up.SetActive(true);
            animatorUpgradeText.Play("moveUpText2");
            animatorBack.Play("moveDownText");
            animator.Play("moveUp");
            isDownPressed = false;
            down.SetActive(false);
            


        }

       
       
    }


    public void downButton()
    {
        isDownPressed = true;
        isUpPressed = false;
    }

    public void upButton()
    {
        isUpPressed = true;
        isDownPressed = false;
            
    }

    
}
