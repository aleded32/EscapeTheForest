using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeSpawning : MonoBehaviour {

    public GameObject tree;
    public GameObject[] objects;
    public GameObject trees;
    public GameObject leaves;
    public GameObject leaf;
    public GameObject backgroundTrees;

    // Use this for initialization
    public void Start()
    {
        objects = new GameObject[3];
        objects[0] = tree;
        objects[1] = leaf;
        objects[2] = backgroundTrees;


        for (int i = 1; i <= 35; i++)
        {
           

            trees = Instantiate(objects[0], new Vector3(i * 15.0f, 11f, 1.0f), Quaternion.identity);
        
            Instantiate(objects[1], new Vector3(i * 15.0f, 11.6f, 0f), Quaternion.identity);

            Instantiate(objects[2], new Vector3(i * 8.0f, 10.35f, 3.09f), Quaternion.identity);

        }
    }
}
