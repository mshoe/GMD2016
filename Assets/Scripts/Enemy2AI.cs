using UnityEngine;
using System.Collections;

public class Enemy2AI : MonoBehaviour {

	Transform tr_Player;
	Transform Win;
	private Rigidbody rb;

	public bool unFaithful;
	public bool leapFaithful;
	public bool onGround;
	public float f_RotSpeed = 6.0f, f_MoveSpeed = 3.0f;

	Behaviour halo;
	public ParticleSystem particles;

	Behaviour Disintegrate;
	public bool deathTime;

	void Start () {
		unFaithful = false;
		leapFaithful = false;
		rb = GetComponent<Rigidbody> ();
		tr_Player = GameObject.FindGameObjectWithTag("Player").transform;
		Win = GameObject.FindGameObjectWithTag ("Finish").transform;
		unFaithful = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ().unFaith;
		leapFaithful = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ().leapFaith;
		halo = (Behaviour)GetComponent ("Halo");
		particles.enableEmission = false;
		Disintegrate = (Behaviour)GetComponent ("Animator");
		Disintegrate.enabled = false;
	}

	void death () {
		if (deathTime == true) {
			Disintegrate.enabled = true;
		}
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag ("ground")) {
			onGround = true;
		}
	}

	void unFaithPower ()
	{
		if (unFaithful) {
			f_MoveSpeed = -5.0f;
			halo.enabled = true;
		} else {
			f_MoveSpeed = 3.0f;
			halo.enabled = false;
		}
	}

	void leapFaithPower ()
	{
		if (leapFaithful) {
			particles.enableEmission = true;
			if (Input.GetKeyDown (KeyCode.Space) && onGround) {
				onGround = false;
				rb.AddForce (Vector3.up * 600);
			}
		} else {
			particles.enableEmission = false;
		}
	}
			
			

	void Update () {
		


		/* Look at Player */
		if (!unFaithful) {
			
			transform.rotation = Quaternion.Slerp (transform.rotation
				, Quaternion.LookRotation (tr_Player.position - transform.position)
				, f_RotSpeed * Time.deltaTime);

			/* Move at Player */
			transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;

			//unFaith PowerUp
			unFaithful = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ().unFaith;

			//leapFaith PowerUp
			leapFaithful = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ().leapFaith;
			leapFaithPower ();

			death ();

			halo.enabled = false;
		} else if (unFaithful) {
			
			transform.rotation = Quaternion.Slerp (transform.rotation
				, Quaternion.LookRotation (Win.position - transform.position)
				, f_RotSpeed * Time.deltaTime);

			/* Move at Player */
			transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;

			//unFaith PowerUp
			unFaithful = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ().unFaith;

			//leapFaith PowerUp
			leapFaithful = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ().leapFaith;
			leapFaithPower ();

			death ();

			halo.enabled = true;
		}
	}
}
