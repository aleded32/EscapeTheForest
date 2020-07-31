using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimePosition : MonoBehaviour {

    public GameObject player;

	

    void Update()
    {
        this.transform.position = new Vector3(player.transform.position.x - 3.5f, 4.5f, 0.1f);
    }


}
