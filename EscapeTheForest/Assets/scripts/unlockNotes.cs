using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class unlockNotes : MonoBehaviour {


    public GameObject note1B;
    public GameObject note2B;
    public GameObject note3B;
    public GameObject note4B;

    // Update is called once per frame
    void Update ()
    {
        unlockingNotes();
	}

    void unlockingNotes()
    {
        switch (PlayerPrefs.GetInt("totalNotes"))
        {

            case 1:
                settingButtons(note1B);
                break;

            case 2:
                settingButtons(note1B);
                settingButtons(note2B);
                break;

            case 3:
                settingButtons(note1B);
                settingButtons(note2B);
                settingButtons(note3B);
                break;

            case 4:
                settingButtons(note1B);
                settingButtons(note2B);
                settingButtons(note3B);
                settingButtons(note4B);
                break;

        };
    }

    void settingButtons(GameObject notes)
    {
        notes.SetActive(true);
    }
}
