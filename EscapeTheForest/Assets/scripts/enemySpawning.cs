using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawning : MonoBehaviour
{


    public GameObject enemyNM;
    public GameObject enemyM;
    public GameObject[] objects;
    public GameObject enemies;



    // Use this for initialization
    public void Start()
    {
        objects = new GameObject[2];
        objects[0] = enemyNM;
        objects[1] = enemyM;

        for (int i = 1; i <= 20; i++)
        {
            int rand = Random.Range(0, 2);

           enemies =  Instantiate(objects[rand], new Vector3(i * 25.0f, 3.1f, -0.03f), Quaternion.identity);

        }
    }

    


}
