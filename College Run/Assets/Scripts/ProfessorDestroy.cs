using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfessorDestroy : MonoBehaviour {

	void Start ()
	{
		GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
		
	}



	void Update () {
		//Check if professor component goes out of the Y axis, if it does, destroy it
		if(transform.position.y < -7f)
		Destroy(gameObject);
	}
}
