using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class noteSpawning : MonoBehaviour {

    public GameObject notes;
    public GameObject notes1;
    public GameObject notes2;
    public GameObject notes3;
    public GameObject canvas;
    public GameObject note1Text;
    public GameObject note2Text;
    public GameObject note3Text;
    public GameObject note4Text;
    public GameObject text;
    bool paused = false;
    public int note;

    

    private void Start()
    {
       
    }

    void Update()
    {

        

        if (Input.GetKey(KeyCode.Space))
        {
            
            switch (note)
            {

                case 1:
                    RemoveNoteOnScreen(note1Text);
                    
                    break;

                case 2:
                    RemoveNoteOnScreen(note2Text);
                    break;

                case 3:
                    RemoveNoteOnScreen(note3Text);
                    break;

                case 4:
                    RemoveNoteOnScreen(note4Text);
                    break;



            };
        }

        if (paused == true)
        {
            Time.timeScale = 0f;
        }
        else if (paused == false)
        {
            Time.timeScale = 1f;
        }

        
    }


    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "notes")
        {

            notes.SetActive(false);
            text.SetActive(true);
            canvas.GetComponent<PauseMenu>().Paused = true;
            note1Text.SetActive(true);
            paused = true;
            
            note += 1;
        }
         if (other.gameObject.tag == "notes1")
        {

            notes1.SetActive(false);
            text.SetActive(true);
            canvas.GetComponent<PauseMenu>().Paused = true;
            note2Text.SetActive(true);
            paused = true;

            note += 1;

        }
        else if (other.gameObject.tag == "notes2")
        {

            notes2.SetActive(false);
            text.SetActive(true);
            canvas.GetComponent<PauseMenu>().Paused = true;
            note4Text.SetActive(true);
            paused = true;

            note += 1;


        }
        else if (other.gameObject.tag == "notes3")
        {

            notes2.SetActive(false);
            text.SetActive(true);
            canvas.GetComponent<PauseMenu>().Paused = true;
            note3Text.SetActive(true);
            paused = true;
            
            note += 1;

        }
    }

    

    void RemoveNoteOnScreen(GameObject note)
    {
        note.SetActive(false);
        text.SetActive(false);
        paused = false;
    }
	
}
