using UnityEngine;
using System.Collections;

public class waterBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag ("enemy")) {
			Destroy (col.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
