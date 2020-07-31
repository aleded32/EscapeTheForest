using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeSpawning : MonoBehaviour {

    public GameObject tree;
    public GameObject[] objects;
    public GameObject trees;
    public GameObject leaves;
    public GameObject leaf;


    // Use this for initialization
    public void Start()
    {
        objects = new GameObject[2];
        objects[0] = tree;
        objects[1] = leaf;


        for (int i = 0; i < 20; i++)
        {
            int rand = Random.Range(0, 2);

            trees = Instantiate(objects[0], new Vector3(i * 15.0f, 11.8f, 1.0f), Quaternion.identity);

            Instantiate(objects[1], new Vector3(i * 15.0f, 11.6f, 0.5f), Quaternion.identity);

        }
    }
}
