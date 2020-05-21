﻿using System.Collections;
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
    public bool isInvincible = false;

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
            int rand = Random.Range(0, 2);
            Debug.Log(rand);
            if (rand == 0)
            {
                InvokeRepeating("timerInvincible", 1, 1);
            }
            else if (rand == 1)
            {
                InvokeRepeating("timerMushroom", 1, 1);
            }
            
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
           player.GetComponent<playerMovement>().doubleJump = false;

        }
        else if (time < 0.3f)
        {
            audio.Stop();
            GetComponent<playerMovement>().speed = 5f;

            if (transform.position.y >= 4.2)
            {

             player.GetComponent<playerMovement>().doubleJump = true;

            }
        }
      
    
    }

    

    public void timerMushroom()
    {
        timeMushroom -= Time.deltaTime;

        if (timeMushroom <= 0)
        {
            timeMushroom = 0.05f;
            player.GetComponent<playerMovement>().jumpSpeed = 2f;
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
            time = 0.08f;

            CancelInvoke("timerInvincible");
            isInvincible = false;
            player.GetComponent<BoxCollider>().isTrigger = false;
            



        }
        else if (timeInvicible < 0.08f)
        {
            
            isInvincible = true;
            
        }

    }

}
