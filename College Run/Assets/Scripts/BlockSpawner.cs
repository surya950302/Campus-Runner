using UnityEngine;

public class BlockSpawner : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject ProfPrefab;
	public GameObject beerPrefab;

	private float timeToSpawn = 2f;
	private float timeToSpawnBeer = 0.001f;

	public float timeBetweenWaves = 1f;
	public float timeBetweenBeer = 0.001f;

	public float delay = 3f;

	// Use this for initialization
	void FixedUpdate ()
	{

		if(Time.time >= timeToSpawn)
		{
			spawnBlocks();
			timeToSpawn = Time.time + timeBetweenWaves;
		}
		if(Time.time >= timeToSpawnBeer)
		{
			spawnBeer();
			timeToSpawnBeer = Time.time + delay + timeBetweenBeer;
		}


		

	}

	void spawnBlocks()
	{
		int randomIndex = Random.Range (0, spawnPoints.Length);
		Instantiate(ProfPrefab, spawnPoints[randomIndex].position,Quaternion.identity);
	}

	void spawnBeer ()
	{
		int randomIndex1 = Random.Range (0, spawnPoints.Length);
		Instantiate(beerPrefab, spawnPoints[randomIndex1].position,Quaternion.identity);
	}
	

}
