using UnityEngine;
using System.Collections;

public class nextLevel1to2 : MonoBehaviour {

	public GameObject Water;
	Behaviour halo;

	void Start () {
		halo = (Behaviour)GetComponent ("Halo");
		halo.enabled = false;
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.CompareTag ("Player")) {
			if (halo.enabled) {
				Application.LoadLevel ("level_2");
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if (Water.GetComponent<waterBehaviour> ().nextLevel) {
			halo.enabled = true;
		}
	}
}
