using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefBoss : MonoBehaviour 
{

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_;" ;

	public static void SetMasterVolume (float volume)
	{
		if (volume > 0f && volume < 1f) 
		{
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume); 
		} 
		else
		{
			Debug.LogError ("Value is out of range");
		}
	}

	public static float GetMasterVolume ()
	{
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY); 
	}

	public static void UnlockedLevel(int level)
	{
		if (level <= SceneManager.sceneCountInBuildSettings) 
		{
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (), 1);
		} 
		else 
		{
			Debug.LogError ("Trying to unlock invalid level");
		}
	}
	public static bool IsLevelUnlocked ( int level)
	{
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isItUnlocked = (levelValue == 1);

		if (level <= SceneManager.sceneCountInBuildSettings) 
		{
			return isItUnlocked;
		}
		else
		{
			Debug.LogError ("Trying to query invalid level"); 
			return false; 
		}
	}
		
	public static void SetDifficulty (int difficulty)
	{
		if (difficulty <= 3 && difficulty > 0) 
		{
			PlayerPrefs.SetInt (DIFFICULTY_KEY, difficulty);
		}
		else
		{
			Debug.LogError ("Difficulty setting not available"); 
		}
	}
	public static int GetDifficulty ()
	{
		return PlayerPrefs.GetInt (DIFFICULTY_KEY);
	}
}
