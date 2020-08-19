using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour {

    public GameObject scoreObj;
    public int currentScore;
    static int highScore;
    public int currentNotes;
    static int notesAquired;
    public Text highScoreText;
    public noteSpawning notesRef;
    public float volume;

    

    private void Update()
    {
        currentScore = scoreObj.GetComponent<scoreSystem>().currentScore;
        currentNotes = notesRef.note;
        notesAquired = currentNotes;
        highScore = currentScore;
        highScoreSet(highScore);
        NumberOfNotes(notesAquired);
        

       
    }

    void highScoreSet(int highScore)
    {

        if(currentScore > PlayerPrefs.GetInt("highScore"))
            PlayerPrefs.SetInt("highScore", highScore);

        highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("highScore");
        
        

        if (Input.GetKeyDown(KeyCode.L))
        {
            PlayerPrefs.SetInt("highScore", 0);
            PlayerPrefs.SetInt("totalNotes", 0);
        }
       
    }

    void NumberOfNotes(int notesAquired)
    {
        if(currentNotes > PlayerPrefs.GetInt("totalNotes"))
            PlayerPrefs.SetInt("totalNotes", notesAquired);
         

    }

   


}
