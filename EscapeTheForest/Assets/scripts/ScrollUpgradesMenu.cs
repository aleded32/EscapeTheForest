using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollUpgradesMenu : MonoBehaviour {

    public GameObject up;
    public GameObject down;
    public GameObject upgradeTree;
    public bool isUpPressed = false;
    public bool isDownPressed = false;
    private int speed = 300;

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

            if (upgradeTree.transform.position.y > 135)
            {
                
                upgradeTree.transform.Translate(Vector2.down * speed * Time.deltaTime);
                down.SetActive(true);
            }
          
        }
        else if (isDownPressed == true)
        {
            up.SetActive(true);

            if (upgradeTree.transform.position.y > -193)
            {
                if (upgradeTree.transform.position.y < 635)
                {
                    upgradeTree.transform.Translate(Vector3.up * speed * Time.deltaTime);
                    down.SetActive(false);
                    
                }
                   

            }
            
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
