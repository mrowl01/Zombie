using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneBoss : MonoBehaviour
{
	public float timeToLoadScene = 3.5f; 


	void Start ()
	{
		ifSceneIs0 (); 
	}

	public void ChangeScene (string theScene)
	{
		SceneManager.LoadScene (theScene);
	}
	public void QuitGame ()
	{
		Application.Quit ();
	}
	public void LoadNextScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1) ; 
	}

	void ifSceneIs0 ()
	{
		int myCurrentScene = SceneManager.GetActiveScene ().buildIndex;

		if (myCurrentScene == 0)
		{
			Invoke ("LoadNextScene", timeToLoadScene); 
		}
	}


}
