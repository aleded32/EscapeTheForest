using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundFollow : MonoBehaviour {

    public Animator animator;
    public GameObject player;
    public GameObject groundSprite;
    public Vector3 playerPos;
    public GameObject fog;
    public float offsetX;

    public void Start()
    {
        offsetX = 5.5f;
    }

    public void Update()
    {
        playerPos = player.transform.position;

        this.transform.SetPositionAndRotation(new Vector3(playerPos.x - offsetX, 10.67f, 6.1f), Quaternion.identity);
        fog.transform.SetPositionAndRotation(new Vector3(playerPos.x - offsetX, 11.5f, -1f), Quaternion.identity);

        for (int i = 0; i <= 26; i++)
        {
            Instantiate(groundSprite, new Vector3(i * 20, 7.2f, 1f), Quaternion.identity);
        }

    }
}
