using UnityEngine;

public class WaveSpawner : MonoBehaviour {

	public Transform enemyPrefav;
	public Transform spawnPoint;
	public float timeBetweenWaves = 5f;
	public float countdown = 2f;

	private int waveNumber = 1;

	void Update ()
	{
		if (countdown <= 0f) 
		{
			SpawnWave ();
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;

	}

	void SpawnWave ()
	{
		Debug.Log ("Wave Incoming!");
		for (int i = 0; i < waveNumber; i++) 
		{
			SpawnEnemy ();
		}
		waveNumber++;
	}

	void SpawnEnemy ()
	{
		Instantiate (enemyPrefav, spawnPoint.position, spawnPoint.rotation);
	}
}
