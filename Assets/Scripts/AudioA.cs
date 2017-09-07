using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioA : MonoBehaviour {

	public AudioClip [] myClipsArray ; 
	AudioSource audioSource ;

	void Awake()
	{
		DontDestroyOnLoad (gameObject); 
	}

	// Use this for initialization
	void Start ()
	{
		audioSource = gameObject.GetComponent<AudioSource> ();
		SceneManager.sceneLoaded += OnSceneLoaded; 
	}




	void OnSceneLoaded (Scene scene, LoadSceneMode mode )
	{
		int myScene = scene.buildIndex; 
		AudioClip currentMusic = myClipsArray [myScene];
		if (currentMusic) 
		{
			audioSource.clip = currentMusic; 
			audioSource.loop = true;
			audioSource.Play ();
		}
	}




}
