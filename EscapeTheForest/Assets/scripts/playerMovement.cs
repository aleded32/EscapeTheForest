using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public float speed = 10f;
    public float jumpSpeed = 2;
    public Rigidbody rb;
    public bool isJumping = false;
    public bool doubleJump = false;
    public GameObject pauseMenu;
    public bool isPaused = false;
    bool gameStart = false;

      

	
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space)) 
        {
            gameStart = true;
        }

        if (gameStart == true)
        {

            if (isPaused == false)
            {

                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

        }

        if (transform.position.y <= 3.18)
        {
            transform.position = new Vector3(transform.position.x, 3.18f);
        }
        

    }


    void FixedUpdate()
    {
        //menu control


       if (Input.GetKey(KeyCode.P) && isPaused == false )
        {

            isPaused = true;
        }

        if (isPaused == true)
        {
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(false);
        }


        //Jumping

        if (isPaused == false)
        {

            if (isJumping == false)
            {
                if (Input.GetKey(KeyCode.W))
                {



                    // transform.Translate(Vector3.up * 0 * Time.deltaTime);
                    //Debug.Log("hi");

                    rb.AddForce(0, 8000 * jumpSpeed * Time.deltaTime, 0);
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
                    if (transform.position.y >= 5) isJumping = true;

                    else if (transform.position.y >= 4.2)
                    {


                        if (Input.GetKey(KeyCode.W))
                        {



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
}
