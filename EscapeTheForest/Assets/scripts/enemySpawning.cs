using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawning : MonoBehaviour {

    
    public GameObject enemyNM;
    public GameObject enemyM;
    public GameObject [] objects;
   


	// Use this for initialization
	void Start ()
    {
        objects = new GameObject[2];
        objects[0] = enemyNM;
        objects[1] = enemyM;

        for (int i = 1; i <= 10; i++)
        {
            int rand = Random.Range(0, 2);

            Instantiate(objects[rand], new Vector3(i * 25.0f, 3.18f), Quaternion.identity);

        }
    }
	
	// Update is called once per frame
	void Update ()
    {

        

	}
}
