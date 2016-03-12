using UnityEngine;
using System.Collections;

public class level3DisapearBridge2 : MonoBehaviour {

	public GameObject water;
	Behaviour Fall;

	void Start () {
		Fall = (Behaviour)GetComponent ("Animator");
		Fall.enabled = false;
	}

	void Update () {
		if (water.GetComponent<waterBehaviour> ().score >= 2) {
			Fall.enabled = true;
		}
	}
}
