using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public int enemyCount;
	public int goodGuyCount;
	public GameObject enemy2;
	public GameObject goodGuy;
	public GameObject PowerUp1;
	public GameObject PowerUp2;
	public GameObject PowerUp3;
	public float timeCount_enemy;
	public float timeCount_goodGuy;
	public float timeCount_PowerUp;
	public float periodEnemy;
	public float periodGoodGuy;

	
	void spawnEnemy () {
		if (enemyCount < 20) {
			Vector3 spawnLocation1 = new Vector3 (Random.Range (-9.0f, 9.0f), 1.0f, Random.Range (-9.0f, 9.0f));
			Instantiate (enemy2, spawnLocation1, Quaternion.identity);
			timeCount_enemy = 0.0f;
		}
	}

	void spawnGoodGuy () {
		Vector3 spawnLocation2 = new Vector3 (Random.Range (-2.0f, 2.0f), 1.0f, Random.Range (-2.0f, 2.0f));
		Instantiate (goodGuy, spawnLocation2, Quaternion.identity);
		timeCount_goodGuy = 0.0f;
	}

//	void spawnPowerUp () {
//		int powerChoose = Random.Range ((int)0, (int)3);
//		GameObject powerUp;
//		if (powerChoose == 1) {
//			powerUp = PowerUp1;
//		} else if (powerChoose == 2) {
//			powerUp = PowerUp2;
//		} else {
//			powerUp = PowerUp3;
//		}
//		Vector3 spawnLocation3 = new Vector3 (Random.Range (-4.0f, 4.0f), 1.0f, Random.Range (-4.0f, 4.0f));
//		Instantiate (powerUp, spawnLocation3, Quaternion.identity);
//		timeCount_PowerUp = 0.0f;
//	}

	void Update () {
		timeCount_enemy += 1.0f;
		timeCount_goodGuy += 1.0f;
		timeCount_PowerUp += 1.0f;

		GameObject[] count = GameObject.FindGameObjectsWithTag("enemy");
		enemyCount = count.Length;
		if (timeCount_enemy >= periodEnemy)
		{
			spawnEnemy ();
		}

		if (timeCount_goodGuy >= periodGoodGuy) {
			spawnGoodGuy ();
		}
//
//		if (timeCount_PowerUp >= 1200.0f) {
//			spawnPowerUp ();
//		}
	}
}
