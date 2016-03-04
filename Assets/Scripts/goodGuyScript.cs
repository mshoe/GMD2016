using UnityEngine;
using System.Collections;

public class goodGuyScript : MonoBehaviour {

	Transform tr_Player;
	public bool leapFaithful;
	public bool onGround;
	public float f_RotSpeed = 4.0f, f_MoveSpeed = 4.0f;

	Behaviour halo;
	private Rigidbody rb;
	public ParticleSystem particles;

	void Start () {
		tr_Player = GameObject.FindGameObjectWithTag("Player").transform;
		rb = GetComponent<Rigidbody> ();
		particles.enableEmission = false;
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.collider.CompareTag ("ground")) {
			onGround = true;
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
		transform.rotation = Quaternion.Slerp (transform.rotation
			, Quaternion.LookRotation (tr_Player.position - transform.position)
			, f_RotSpeed * Time.deltaTime);

		/* Move at Player */
		transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;

		//leapFaithPowerUp
		leapFaithful = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ().leapFaith;
		leapFaithPower ();
	}
}
