using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondLayerMove : MonoBehaviour {

    public GameObject player;
    float speed = 4f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (player.GetComponent<playerMovement>().gameStart == true)
        {
            transform.Translate(Vector3.Normalize(Vector3.right) * speed * Time.deltaTime);
        }
    }
}
