using UnityEngine;
using System.Collections;

public class roofBehaviour : MonoBehaviour {

	public GameObject player;
	public GameObject roof1;
	public GameObject roof2;
	public GameObject roof3;
	public GameObject roof4;
	public bool roof1State;
	public bool roof2State;
	public bool roof3State;
	public bool roof4State;


	void Start () {
		roof1State = true;
		roof2State = true;
		roof3State = true;
		roof4State = true;
	}

	void roof1Active () {
		if ((player.transform.position.x < 21.0 && player.transform.position.x > -8.0)
			&& (player.transform.position.z < 32.5 && player.transform.position.z > 13.5)) {
			roof1.SetActive (false);
		} else {
			roof1.SetActive (true);
		}
	}

	void roof2Active () {
		if ((player.transform.position.x < 21.0 && player.transform.position.x > -8.0)
			&& (player.transform.position.z > -32.5 && player.transform.position.z < -13.5)) {
			roof2.SetActive (false);
		} else {
			roof2.SetActive (true);
		}
	}

	void roof3Active () {
		if ((player.transform.position.x < 85.5 && player.transform.position.x > 56.5)
			&& (player.transform.position.z < -32.5 && player.transform.position.z > -13.5)) {
			roof3.SetActive (false);
		} else {
			roof3.SetActive (true);
		}
	}

	void roof4Active () {
		if ((player.transform.position.x < 85.5 && player.transform.position.x > 56.5)
			&& (player.transform.position.z < 32.5 && player.transform.position.z > 13.5)) {
			roof4.SetActive (false);
		} else {
			roof4.SetActive (true);
		}
	}

	void Update () {
		roof1Active ();
		roof2Active ();
		roof3Active ();
		roof4Active ();
	}
}