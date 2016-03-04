using UnityEngine;
using System.Collections;

public class PowerUp1 : MonoBehaviour {

	public int time;
	public bool Clone = false;

	void Start() {
		time = 0;
		if (transform.position.x < 5.0f && transform.position.x > -5.0f) {
			Clone = true;
		}
	}

	void Update(){
		time += 1;
		if (time == 600 && Clone) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag ("Player")) {
			col.gameObject.GetComponent<PlayerController> ().speedPower = true;
			Destroy (gameObject);
		}
	}
}
