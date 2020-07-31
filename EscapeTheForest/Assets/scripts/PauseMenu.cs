using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool Paused = false;
    public bool settingActive = false;

    public GameObject PauseMenuUI;
    public GameObject settingMenuUI;

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
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    void Pause ()
    {
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
}
