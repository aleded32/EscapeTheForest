using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public bool Paused = false;
    public bool settingActive = false;

    public GameObject PauseMenuUI;
    public GameObject settingMenuUI;
    public GameObject text;
    public GameObject noOfNotes;
    public GameObject highScore;

	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Resume();
            } else
            {
                Pause();

            }
        }

        

	}

    public void Resume()
    {
        highScore.SetActive(true);
        text.SetActive(true);
        noOfNotes.SetActive(true);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    void Pause ()
    {
        highScore.SetActive(false);
        text.SetActive(false);
        noOfNotes.SetActive(false);
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }

    public void settings()
    {

        PauseMenuUI.SetActive(false);
        Time.timeScale = 0f;
        settingActive = true;
        settingMenuUI.SetActive(true);
    }

    public void settingsOff()
    {
       
        settingMenuUI.SetActive(false);
    }
}
