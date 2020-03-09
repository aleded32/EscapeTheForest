using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float speed = 5f;
    float jumpSpeed = 2;
    public Rigidbody rb;
    public bool isJumping = false;
    bool doubleJump = true;
    

	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {

       
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        
        

    }


    void FixedUpdate()
    {



        if (isJumping == false)
        {
            if (Input.GetKey(KeyCode.W))
            {


                
                // transform.Translate(Vector3.up * 0 * Time.deltaTime);
                //Debug.Log("hi");

                rb.AddForce(0, 10000 * jumpSpeed * Time.deltaTime, 0);
                isJumping = true;

            }

            

        }
        else if (isJumping == true)
        {
            if (transform.position.y <= 3.2)
            {

                isJumping = false;

            }

            else if (doubleJump == false)
            { 
                if (transform.position.y >= 6) isJumping = true;

                else if (transform.position.y >= 5.2)
                {



                    isJumping = false;


                }
            }
             
        }
        

        

    }
}
