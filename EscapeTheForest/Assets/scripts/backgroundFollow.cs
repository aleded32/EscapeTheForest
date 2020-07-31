using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundFollow : MonoBehaviour {

    public Animator animator;
    public GameObject player;
    public Vector3 playerPos;
    public float offsetX;

    public void Start()
    {
        offsetX = 5.5f;
    }

    public void Update()
    {
        playerPos = player.transform.position;

        this.transform.SetPositionAndRotation(new Vector3(playerPos.x - offsetX, 11.67f, 6.1f), Quaternion.identity);
    }
}
