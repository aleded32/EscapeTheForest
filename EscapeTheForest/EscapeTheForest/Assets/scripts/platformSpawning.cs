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
            

            Instantiate(platform, new Vector3(i * 78.0f, 5.6f), Quaternion.identity);

        }
	}
	
	
}
