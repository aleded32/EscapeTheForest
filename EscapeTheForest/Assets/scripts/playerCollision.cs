using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerCollision : MonoBehaviour {

    int hitCount = 0;
    float time = 0.3f;
    float timeInvicible = 0.08f;
    float timeMushroom = 0.05f;
    float timeSlowdown = 0.08f;
    public AudioSource audio;
    public Image currentBuff;
    public Sprite jump;
    public Sprite invicible;
    public Sprite empty;
    public AudioSource audioDebuff;
    public AudioClip normal;
    public AudioClip debuff;
    public GameObject player;
    public GameObject powerup;
    public GameObject powerup2;
    public GameObject powerup3;
    public GameObject powerup4;
    public GameObject slimeWave;
    public Animator animator;
    public bool isInvincible = false;
    public Animator animationPlayer;

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy" && isInvincible == false)
        {

            SceneManager.LoadScene("GameScreen");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "powerup")
        {

            Destroy(powerup);

            InvokeRepeating("timerInvincible", 0, 1);
            if (time < 0.3f)
            {
                CancelInvoke("timer");
            }

        }
        else if (collision.gameObject.tag == "powerup2")
        {

            Destroy(powerup2);
            InvokeRepeating("timerMushroom", 0, 1);
            if (time < 0.3f)
            {
                CancelInvoke("timer");
            }

        }
        else if (collision.gameObject.tag == "powerup3")
        {

            Destroy(powerup3);
            InvokeRepeating("timerInvincible", 0, 1);
            if (time < 0.3f)
            {
                CancelInvoke("timer");
            }

        }
        else if (collision.gameObject.tag == "powerup4")
        {
            Destroy(powerup4);
            InvokeRepeating("timerMushroom", 0, 1);
            if (time < 0.3f)
            {
                CancelInvoke("timer");
            }
        }
        else if (collision.gameObject.tag == "platform")
        {

            animator.SetBool("isFalling", false);
            animator.SetBool("isJumping", false);
            animator.SetBool("isDoubleJumping", false);
        }



    }

    private void OnTriggerExit2D(Collider2D trigger) 
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
            animationPlayer.SetBool("hasCollided", false);
            slimeWave.GetComponent<SpriteRenderer>().enabled = false;
            audioDebuff.Stop();
           audio.clip = normal;
           audio.Play();
            hitCount = 0;
           Debug.Log("time over");
            

            CancelInvoke("timer");


        }
        else if (time < 0.3f)
        {
            audio.Stop();
            GetComponent<playerMovement>().speed = 5f;
            animationPlayer.SetBool("hasCollided", true);
            slimeWave.GetComponent<SpriteRenderer>().enabled = true;
           
        
             
             
            
        }
      
    
    }

    

    public void timerMushroom()
    {
        timeMushroom -= Time.deltaTime;

        if (timeMushroom <= 0)
        {
            currentBuff.sprite = empty;
            timeMushroom = 0.05f;
            player.GetComponent<playerMovement>().jumpSpeed = 1.75f;
            CancelInvoke("timerMushroom");



        }
        else if (timeMushroom < 0.05f)
        {
            currentBuff.sprite = jump;
            player.GetComponent<playerMovement>().jumpSpeed = (1.75f * 2);

        }

    }

    public void timerInvincible()
    {

       
        timeInvicible -= Time.deltaTime;

        if (timeInvicible <= 0)
        {
            time = 0.06f;
            currentBuff.sprite = empty;
            CancelInvoke("timerInvincible");
            isInvincible = false;
            player.GetComponent<BoxCollider2D>().isTrigger = false;
            



        }
        else if (timeInvicible < 0.06f)
        {
            currentBuff.sprite = invicible;
            isInvincible = true;
            
        }

    }

}
