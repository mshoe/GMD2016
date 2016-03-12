using UnityEngine;
using System.Collections;

public class fallDownWalls : MonoBehaviour {

	public GameObject water;
	Behaviour Fall;
	void Start () {
		Fall = (Behaviour)GetComponent ("Animator");
		Fall.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (water.GetComponent<waterBehaviour> ().score == water.GetComponent<waterBehaviour> ().scoreTotal) {
			Fall.enabled = true;
		}
	}
}
