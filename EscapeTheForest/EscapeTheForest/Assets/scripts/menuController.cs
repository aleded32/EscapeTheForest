using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuController : MonoBehaviour {

    public GameObject player;
    bool ispaused;

    public void ResumeGame()
    {
        player.GetComponent<playerMovement>().isPaused = ispaused;
        ispaused = false;
    }

    public void Quit() 
    {
        Debug.Log("QIUT");
       Application.Quit();
    }

    
}
