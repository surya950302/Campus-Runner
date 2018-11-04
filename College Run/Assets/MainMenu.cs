using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
	{
		FindObjectOfType<AudioManager>().Play("btn_click");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void EndGame ()
	{
		Debug.Log("End");
		Application.Quit();
	}
}
