using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audioSave : MonoBehaviour {


    public AudioSource audioSource;
    public GameObject audio;
    public GameObject settings;
    public float volume;
	
	// Update is called once per frame
	void Update ()
    {
        volume = audioSource.volume;
        PlayerPrefs.SetFloat("currentVolume", volume);
        DontDestroyOnLoad(audio);
        DontDestroyOnLoad(settings);
	}
}
