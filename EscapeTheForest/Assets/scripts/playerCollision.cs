using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour {

    int hitCount = 0;
    float time = 0.3f;
    public AudioSource audio;
    public AudioSource audioDebuff;
    public AudioClip normal;
    public AudioClip debuff;

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
            audioDebuff.clip = debuff;
            audioDebuff.Play();

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
            time = 0.3f;
           GetComponent<playerMovement>().speed = 10f;
           CancelInvoke("timer");

           audioDebuff.Stop();
           audio.clip = normal;
           audio.Play();
           
        }
        else if (time < 0.3f)
        {
            audio.Stop();
            GetComponent<playerMovement>().speed = 5f;
            
            

        }
      
    
    }



}
