using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupPositioning : MonoBehaviour {

    public GameObject powerup;
    public GameObject powerup2;
    public GameObject powerup3;
    public GameObject powerup4;
    public GameObject pointLight;
    GameObject blank;
    public GameObject[] powerups;
    private float[] Yposition;


    // Use this for initialization
    void Start ()
    {
        
        powerups = new GameObject[5];
        Yposition = new float[2];
        powerups[0] = blank;
        powerups[1] = powerup;
        powerups[2] = powerup2;
        powerups[3] = powerup3;
        powerups[4] = powerup4;
        Yposition[0] = 3.18f;
        Yposition[1] = 5.2f;





        for (int i = 1; i < 5; i++)
        {
            

                int randYposition = Random.Range(0, 2);
                int randMultiplyer = Random.Range(1, 3);

                powerups[i].transform.position = new Vector3((i*randMultiplyer) * 60f, Yposition[randYposition], -0.03f);
                Instantiate(pointLight, new Vector3((i * randMultiplyer) * 60f, Yposition[randYposition], -0.036f), Quaternion.identity);
            
        }

    }
	
	
}
