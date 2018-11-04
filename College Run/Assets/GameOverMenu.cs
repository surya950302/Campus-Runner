using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour {

	public GameObject gameOverUI;
	public Text displayScore;
	//public Text gameOverScore;
	public int finscore;

	void Update()
	{
		Score core = new Score();
		core.score = PlayerPrefs.GetInt("Highscore");
		Debug.Log(core.score);
		displayScore.text = core.score.ToString("0");


	}

	public void TryAgain ()
	{
		//FindObjectOfType<GameManager>().EndGame();
		Time.timeScale = 1f;
		SceneManager.LoadScene ("MainLevel");
		//GameIsOver = true;	
	}

	public void QuitGame ()
	{
		Application.Quit();
	}

}
