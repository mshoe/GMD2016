using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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

	//two leapFaith bools, same reason^
	public bool leapFaith = false;
	public bool leapFaithPower = false;
	public int leapFaithTimer = 0;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		halo = (Behaviour)GetComponent ("Halo");
	}
		
	void OnCollisionEnter (Collision col)
	{
		if (col.collider.CompareTag ("ground")) {
			onGround = true;
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
		else if (speedPowerTimer > 0) {
			speedPowerTimer -= 1;
		}
		else if (speedPowerTimer <= 0) {
			speedPowerTimer = 0;
			speed = 10;
			strength = 300;
			halo.enabled = false;
		}
	}
		
	void unFaithPowerUp()
	{
		if (unFaithPower) {
			unFaithTimer = 300;
			unFaithPower = false;
			unFaith = true;
		}
		else if (unFaithTimer > 0) {
			unFaithTimer -= 1;
		}
		else if (unFaithTimer <= 0) {
			unFaithTimer = 0;
			unFaith = false;
		}
	}

	void leapFaithPowerUp()
	{
		if (leapFaithPower) {
			leapFaithTimer = 600;
			leapFaithPower = false;
			leapFaith = true;
		} 
		else if (leapFaithTimer > 0) {
			leapFaithTimer -= 1;
		} 
		else if (leapFaithTimer <= 0) {
			leapFaithTimer = 0;
			leapFaith = false;
		}
	}

	void FixedUpdate ()
	{

		//Movement Physics
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float jump = 0.0f;

		if (Input.GetKeyDown (KeyCode.Space) && onGround) {
			jump = 1.0f;
			onGround = false;
		}

		Vector3 finalMovement = new Vector3 (moveHorizontal * speed, jump * strength, moveVertical * speed);

		transform.position += finalMovement * Time.deltaTime;

		//speedPowerUp
		speedPowerUp ();

		//unFaithPowerUp
		unFaithPowerUp ();

		//leapFaithPowerUp
		leapFaithPowerUp ();
	}
}
