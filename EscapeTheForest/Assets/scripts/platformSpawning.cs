using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawning : MonoBehaviour {

    public GameObject platform;

	// Use this for initialization
	void Start () 
    {
        for (int i = 1; i <= 10; i++)
        {
            

            Instantiate(platform, new Vector3(i * 40.0f, 4.7f), Quaternion.identity);

        }
	}
	
	
}
