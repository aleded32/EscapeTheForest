using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showNotes : MonoBehaviour {

    public GameObject note1Screen;
    public GameObject note2Screen;
    public GameObject note3Screen;
    public GameObject note4Screen;
    public GameObject noteMenu;

     

    private void Update()
    {

        if (note1Screen.activeSelf == true)
        {
            MousePressToExit(note1Screen);
        }
        else if (note2Screen.activeSelf == true)
        {
            MousePressToExit(note2Screen);
        }
        else if (note3Screen.activeSelf == true)
        {
            MousePressToExit(note3Screen);
        }
        else if (note4Screen.activeSelf == true)
        {
            MousePressToExit(note4Screen);
        }

    }

    void MousePressToExit(GameObject noteScreen)
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            noteScreen.SetActive(false);
            

        }
    }


    public void note1Button()
    {
        note1Screen.SetActive(true);
    }
    public void note2Button()
    {
        note2Screen.SetActive(true);
    }
    public void note3Button()
    {
        note3Screen.SetActive(true);
    }
    public void note4Button()
    {
        note4Screen.SetActive(true);

    }
    

}
