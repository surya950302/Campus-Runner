using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public float slownessFactor = 10f;

	public void EndGame ()
	{
		StartCoroutine(RestartLevel());
	}

	IEnumerator RestartLevel ()
	{
		//This changes the timescale, basically makes it slower
		Time.timeScale = 1f/slownessFactor;
		Time.fixedDeltaTime = Time.fixedDeltaTime / slownessFactor;

		//Wait for 1 second to restart level
		yield return new WaitForSeconds(1f / slownessFactor);

		Time.timeScale = 1f;
		Time.fixedDeltaTime = Time.fixedDeltaTime * slownessFactor;

		//Load the scene again when it crashes
		SceneManager.LoadScene ("MainLevel");
	}

}
