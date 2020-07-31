using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removePopup : MonoBehaviour {

    bool playAnimation = false;
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.KeypadEnter) && playAnimation == false)
        {
            GetComponent<Animator>().Play("popupScreen");
            playAnimation = true;
        }
        else
        {
            GetComponent<Animator>().StopPlayback();
        }
    }
}
