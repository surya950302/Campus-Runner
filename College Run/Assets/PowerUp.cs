using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	void OnTriggerEnter (Collider col)
	{
		if(col.CompareTag("Player"))
		Pickup();
	}

	void Pickup ()
	{
		Destroy(gameObject);
	}
}
