using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Animator animation;
    public float speed = 10f;
    public float jumpSpeed = 1.75f;
    public Rigidbody rb;
    public bool isJumping = false;
    public bool doubleJump = false;
    public bool gameStart = false;

      

	
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space)) 
        {
            gameStart = true;
        }

        if (gameStart == true)
        {
                animation.SetFloat("speed", speed);
                transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

      

    }


    void FixedUpdate()
    {

        //Jumping
            if (isJumping == false)
            {
                if (Input.GetKey(KeyCode.W))
                {



                    // transform.Translate(Vector3.up * 0 * Time.deltaTime);
                    //Debug.Log("hi");

                    rb.AddForce(0, 8000 * jumpSpeed * Time.deltaTime, 0);
                    isJumping = true;
                    animation.SetBool("isJumping", true);

                }
                


            }
            else if (isJumping == true)
            {
                
                if (transform.position.y <= 3.2)
                {

                    isJumping = false;
                    doubleJump = false;
                    animation.SetBool("isJumping", false);
                    animation.SetBool("isDoubleJumping", false);
                }

                else if (doubleJump == false)
                {
                    if (transform.position.y >= 5)
                    {
                        isJumping = true;
                        doubleJump = true;
                    }
                    else if (transform.position.y >= 4.2)
                    {


                        if (Input.GetKey(KeyCode.W))
                        {


                            animation.SetBool("isDoubleJumping", true);
                            // transform.Translate(Vector3.up * 0 * Time.deltaTime);
                            //Debug.Log("hi");

                            rb.AddForce(0, 400 * 2 * Time.deltaTime, 0);
                            isJumping = true;
                            

                        }



                    }
                }

            }


        
        
        

    }
}
