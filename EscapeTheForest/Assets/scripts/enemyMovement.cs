using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {


    public float enemySpeed = 13f;
    private GameObject player;


    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x >= transform.position.x - 10)
        { 
            transform.Translate(Vector2.left * enemySpeed * Time.deltaTime);

        }
    }

}
