using UnityEngine;
using System.Collections;

public class doorFunction : MonoBehaviour {

	// Use this for initialization

	public bool playerContact;
	Behaviour Open;
	public float distance;

	public GameObject player;

	public Vector3 offset;

	void Start () {
		playerContact = false;
		Open = (Behaviour)GetComponent ("Animator");
		Open.enabled = false;
		offset = transform.position - player.transform.position;
	}
		
	void playerDoorPower () {
		if (offset.magnitude <= distance) {
			playerContact = true;
		} else {
			playerContact = false;
		}
	}

	void openDoor ()
	{
		if (playerContact) {
			Open.enabled = true;
			gameObject.GetComponent<BoxCollider> ().enabled = false;
		}
	}

	void Update () {
		offset = gameObject.transform.position - player.transform.position;
		playerDoorPower ();
		openDoor ();
	}
}
