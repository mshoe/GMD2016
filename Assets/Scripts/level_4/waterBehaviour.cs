using UnityEngine;
using System.Collections;

public class waterBehaviour : MonoBehaviour {

	public int score;
	public int scoreTotal;
	public bool nextLevel;

	void Start () {
		nextLevel = false;
		score = 0;
		scoreTotal = GameObject.FindGameObjectsWithTag ("enemy").Length;
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag ("enemy")) {
			Destroy (col.gameObject);
			score += 1;
		} else if (col.gameObject.CompareTag ("Player")) {
			Destroy (col.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		if (score == scoreTotal) {
			nextLevel = true;
		}
	}
}
