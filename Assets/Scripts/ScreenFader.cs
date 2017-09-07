using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class ScreenFader : MonoBehaviour 
{

	public float timeToFade=3f; 
	Color myCurrentColor ;

	void Start ()
	{
		GetComponent<Image> ().CrossFadeAlpha(0, timeToFade, false);
	}
	void Update()
	{
		if (Time.timeSinceLevelLoad > timeToFade)
			gameObject.SetActive (false); 
	}


}
