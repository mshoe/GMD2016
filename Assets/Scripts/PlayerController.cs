using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

	public float speed;
	public float strength;
	public bool onGround;

	Behaviour halo;

	public bool speedPower = false;
	public int speedPowerTimer = 0;

	//two unFaith bools, one for player, one for enemy
	public bool unFaith = false;
	public bool unFaithPower = false;
	public int unFaithTimer = 0;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		halo = (Behaviour)GetComponent ("Halo");
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag ("ground")) {
			onGround = true;
		} else {
			onGround = false;
		}
	}

	void speedPowerUp()
	{
		if (speedPower) {
			speed += 25;
			strength += 150;
			speedPower = false;
			halo.enabled = true;
			speedPowerTimer = 600;
		}
		if (speedPowerTimer > 0) {
			speedPowerTimer -= 1;
		}
		if (speedPowerTimer <= 0) {
			speedPowerTimer = 0;
			speed = 10;
			strength = 150;
			halo.enabled = false;
		}
	}
		
	void unFaithPowerUp()
	{
		if (unFaithPower) {
			unFaithTimer = 900;
			unFaithPower = false;
			unFaith = true;
		}
		if (unFaithTimer > 0) {
			unFaithTimer -= 1;
		}
		if (unFaithTimer <= 0) {
			unFaithTimer = 0;
			unFaith = false;
		}
	}

	void FixedUpdate ()
	{
		//speedPowerUp
		speedPowerUp ();

		//unFaithPowerUp
		unFaithPowerUp ();

		//Movement Physics
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float jump = 0.0f;

		if (Input.GetKeyDown (KeyCode.Space) && onGround) {
			jump = 1.0f;
			onGround = false;
		}

		Vector3 finalMovement = new Vector3 (moveHorizontal * speed, jump * strength, moveVertical * speed);

		rb.AddForce (finalMovement);
	}
}
