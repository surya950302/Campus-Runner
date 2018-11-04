using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float speed = 15f;
	private Rigidbody2D rb;
	private float mapWidth = 7f;

	public int beerBar = 0;
	int count = 0;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();

	}

	void Update ()
	{
		float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
		//float y = Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed;

		Vector2 newPosition = rb.position + Vector2.right * x;

		//Vector2 newPositiony = rb.position + Vector2.up * y;
		//Vector2 newPositiony = rb.position + Vector2.up * y;
		newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
		//newPositiony.y = Mathf.Clamp(newPositiony.y, -mapWidth, mapWidth);

		rb.MovePosition(newPosition);
		//rb.MovePosition(newPositiony);
	}


	private void OnCollisionEnter2D(Collision2D collision)
   {
   		
      //Debug.Log(collision.collider.name);
       if(collision.gameObject.name == "Professor"|| collision.gameObject.name == "Professor(Clone)")
       {
           //FindObjectOfType<GameManager>().EndGame();
           Time.timeScale = 0f;
			if((gameObject.name == "Professor")||(gameObject.name == "Professor(Clone)"))
			gameObject.SetActive(false);

			SceneManager.LoadScene("MasterLevel", LoadSceneMode.Additive);
       }
       if (collision.gameObject.name == "beer"|| collision.gameObject.name == "beer(Clone)")
       {
        
          Destroy(collision.gameObject);
       
       }

    
   }

   /*
   public float beerScoreUpdate (int count)
	{
		int i = count;
		//Debug.Log("Count:"+count);
		for (i = 0; i <= 40; i += 10) {
			speed = speed + 5f;
		}

		int j = count;
		while (j > 50) {
			speed = speed - 5f;
		}
		count = 0;
		return speed;
	}

	*/

	//void OnCollisionEnter2D ()
	//{	

	//	Time.timeScale = 0f;
	//	SceneManager.LoadScene("MasterLevel");

		//GameObject.FindObjectOfType<GameManager>().EndGame();
		//GameObject.FindObjectOfType<GameManagerBeer>().EGame();



	//}
	//void OnCollisionEnter (Collision col)
	//{
	//	if (col.gameObject.name.Equals("beer")) {
	//	SceneManager.LoadScene("MainLevel");
	//		Debug.Log ("Beer");
	//	}

	//	else
	//	Debug.Log("Professor");
	//}



}
