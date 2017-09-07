using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Test : MonoBehaviour 
{

	void Start ()
	{
		print (PlayerPrefBoss.GetDifficulty ());
		PlayerPrefBoss.SetDifficulty (3);
		print (PlayerPrefBoss.GetDifficulty ());
	}

}
