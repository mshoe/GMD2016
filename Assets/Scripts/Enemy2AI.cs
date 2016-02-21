using UnityEngine;
using System.Collections;

public class Enemy2AI : MonoBehaviour {

	Transform tr_Player;
	public bool unFaithful;
	public float f_RotSpeed = 3.0f, f_MoveSpeed = 3.0f;

	Behaviour halo;


	void Start () {
		tr_Player = GameObject.FindGameObjectWithTag("Player").transform;
		unFaithful = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ().unFaith;
		halo = (Behaviour)GetComponent ("Halo");
	}

	void Update () {
		
		//unFaith PowerUp
		unFaithful = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ().unFaith;
		if (unFaithful) {
			f_MoveSpeed = -3.0f;
			halo.enabled = true;
		} else {
			f_MoveSpeed = 3.0f;
			halo.enabled = false;
		}

		/* Look at Player */
		transform.rotation = Quaternion.Slerp (transform.rotation
			, Quaternion.LookRotation (tr_Player.position - transform.position)
			, f_RotSpeed * Time.deltaTime);

		/* Move at Player */
		transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
	}
}
