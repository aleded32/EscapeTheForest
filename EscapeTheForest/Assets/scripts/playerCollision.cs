using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour {

    int hitCount = 0;
    float time = 0.3f;
    public int notes = 0;
    public AudioSource audio;
    public AudioSource audioDebuff;
    public AudioClip normal;
    public AudioClip debuff;
    public GameObject player;
    public GameObject invincible;
    public GameObject mushroom;
    public GameObject slowdown;
    public GameObject enemyM;
    public GameObject enemyNM;



    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log(1);
            SceneManager.LoadScene("GameScreen");
        }


        if (collision.gameObject.tag == "invincible")
        {
            Destroy(invincible);
            InvokeRepeating("timerInvincible", 1, 1);
        }

        if (collision.gameObject.tag == "mushroom")
        {
            Destroy(invincible);
            InvokeRepeating("timerMushroom", 1, 1);
        }

        if (collision.gameObject.tag == "slowdown")
        {
            Destroy(invincible);
            InvokeRepeating("timerSlowdown", 1, 1);
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

    public void timerSlowdown()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            time = 0.2f;
            enemyM.GetComponent<enemyMovement>().enemySpeed = 13f;
            CancelInvoke("timerSlowdown");

            

        }
        else if (time < 0.2f)
        {
            
            enemyM.GetComponent<enemyMovement>().enemySpeed = 6f;

        }

    }

    public void timerMushroom()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            time = 0.2f;
            GetComponent<playerMovement>().jumpSpeed = 2f;
            CancelInvoke("timerMushroom");



        }
        else if (time < 0.2f)
        {
            
            enemyM.GetComponent<enemyMovement>().enemySpeed = 4f;

        }

    }

    public void timerInvincible()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            time = 0.2f;
            enemyM.GetComponent<BoxCollider>().enabled = true;
            enemyNM.GetComponent<BoxCollider>().isTrigger = true;
            CancelInvoke("timerInvincible");



        }
        else if (time < 0.2f)
        {

            enemyM.GetComponent<BoxCollider>().enabled = false;
            enemyNM.GetComponent<BoxCollider>().isTrigger = false;
        }

    }

}
