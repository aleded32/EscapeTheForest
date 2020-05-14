using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupSpawning : MonoBehaviour
{

    public GameObject invincible;
    public GameObject slowdown;
    public GameObject mushroom;
    public GameObject [] randPowerup;

	// Use this for initialization
	void Start ()
    {
        randPowerup = new GameObject[3];
        randPowerup[0] = invincible;
        randPowerup[1] = slowdown;
        randPowerup[2] = mushroom;

        for (int i = 2; i <= 4; i++)
        {
            int rand = Random.Range(0, 2);

            Instantiate(randPowerup[rand], new Vector3(i * 78.0f, 6.4f), Quaternion.identity);

        }


    }
	
	
}
