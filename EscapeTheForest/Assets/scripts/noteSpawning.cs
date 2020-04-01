using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteSpawning : MonoBehaviour {

    public GameObject notes;
    public GameObject notes1;
    public GameObject notes2;
    public GameObject notes3;
    public int note;
    

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "notes")
        {

            Destroy(notes);

            //Debug.Log("notes");
            note = 1;
        }
         if (other.gameObject.tag == "notes1")
        {

            Destroy(notes1);

            //Debug.Log("notes");
            note = 2;

        }
        else if (other.gameObject.tag == "notes2")
        {

            Destroy(notes2);

            //Debug.Log("notes");
            note = 4;


        }
        else if (other.gameObject.tag == "notes3")
        {

            Destroy(notes3);

            //Debug.Log("notes");
            note = 3;

        }
    }
	
}
