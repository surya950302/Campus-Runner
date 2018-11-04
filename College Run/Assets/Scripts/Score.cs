using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	public int score;

	// Update is called once per frame
	void Update () {
		score = (int)Time.timeSinceLevelLoad*2;
		scoreText.text = score.ToString("0");
		//Debug.Log(score);
		PlayerPrefs.SetInt("Highscore", score);

	}

	public string getScore ()
	{
		return scoreText.text;
	}

}
