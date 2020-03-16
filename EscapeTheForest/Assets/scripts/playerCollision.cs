using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour {

    int hitCount = 0;
    float time = 0.2f;

    void Update() 
    {

        Debug.Log(hitCount);
    }
    
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log(1);
            SceneManager.LoadScene("GameScreen");
        }

    }

    private void OnTriggerExit(Collider trigger) 
    {
        if (trigger.gameObject.tag == "Obstacle")
        {

            InvokeRepeating("timer", 1, 1);
            hitCount += 1;

            if (hitCount >= 4)
            {
                SceneManager.LoadScene("GameScreen");
            }
        }
    }

    public void timer() 
    {
            time -= Time.deltaTime;
        
       if (time <= 0)
        {
            time = 0.2f;
           GetComponent<playerMovement>().speed = 10f;
           CancelInvoke("timer");
           
        }
        else if (time < 0.2f)
        {
            GetComponent<playerMovement>().speed = 5f;

        }
      
    
    }



}
