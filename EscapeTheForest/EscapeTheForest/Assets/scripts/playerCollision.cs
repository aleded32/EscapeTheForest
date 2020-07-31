using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour {

    int hitCount = 0;
    float time = 0.3f;
    float timeInvicible = 0.08f;
    float timeMushroom = 0.05f;
    float timeSlowdown = 0.08f;
    public int notes = 0;
    public AudioSource audio;
    public AudioSource audioDebuff;
    public AudioClip normal;
    public AudioClip debuff;
    public GameObject player;
    public GameObject powerup;
    public GameObject powerup2;
    public GameObject powerup3;
    public GameObject powerup4;
    public GameObject slimeWave;
    public bool isInvincible = false;
    public Animator animationPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" && isInvincible == false)
        {
            Debug.Log(1);
            SceneManager.LoadScene("GameScreen");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {




        if (collision.gameObject.tag == "powerup")
        {

            Destroy(powerup);
            InvokeRepeating("timerInvincible", 1, 1);
           

        }
        else if (collision.gameObject.tag == "powerup2")
        {

            Destroy(powerup2);
            InvokeRepeating("timerMushroom", 1, 1);


        }
        else if (collision.gameObject.tag == "powerup3")
        {

            Destroy(powerup3);
            InvokeRepeating("timerInvincible", 1, 1);

        }
        else if (collision.gameObject.tag == "powerup4")
        {
            Destroy(powerup4);
            InvokeRepeating("timerMushroom", 1, 1);
        }



    }

    private void OnTriggerExit(Collider trigger) 
    {
        if (trigger.gameObject.tag == "Obstacle" && isInvincible == false)
        {

            InvokeRepeating("timer", 1, 1);
            hitCount += 1;
            audioDebuff.clip = debuff;
            audioDebuff.Play();
            
            if (hitCount >= 2)
            {
                SceneManager.LoadScene("GameScreen");
            }
        }
    }

    public void timer() 
    {
            time -= Time.deltaTime;
        
       if (time <= 0.2)
        {
            time = 0.3f;
           GetComponent<playerMovement>().speed = 10f;
           CancelInvoke("timer");
            animationPlayer.SetBool("hasCollided", false);
            slimeWave.GetComponent<SpriteRenderer>().enabled = false;
            audioDebuff.Stop();
           audio.clip = normal;
           audio.Play();
           Debug.Log("time over");

        }
        else if (time < 0.3f)
        {
            audio.Stop();
            GetComponent<playerMovement>().speed = 5f;
            animationPlayer.SetBool("hasCollided", true);
            slimeWave.GetComponent<SpriteRenderer>().enabled = true;
            Debug.Log(time);
        
             
             
            
        }
      
    
    }

    

    public void timerMushroom()
    {
        timeMushroom -= Time.deltaTime;

        if (timeMushroom <= 0)
        {
            timeMushroom = 0.05f;
            player.GetComponent<playerMovement>().jumpSpeed = 1.75f;
            CancelInvoke("timerMushroom");



        }
        else if (timeMushroom < 0.05f)
        {
            
            player.GetComponent<playerMovement>().jumpSpeed = 10f;

        }

    }

    public void timerInvincible()
    {

       
        timeInvicible -= Time.deltaTime;

        if (timeInvicible <= 0)
        {
            time = 0.1f;

            CancelInvoke("timerInvincible");
            isInvincible = false;
            player.GetComponent<BoxCollider>().isTrigger = false;
            



        }
        else if (timeInvicible < 0.1f)
        {
            
            isInvincible = true;
            
        }

    }

}
