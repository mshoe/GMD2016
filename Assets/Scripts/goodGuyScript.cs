using UnityEngine;
using System.Collections;

public class goodGuyScript : MonoBehaviour {

	Transform tr_Player;
	public float f_RotSpeed = 4.0f, f_MoveSpeed = 4.0f;

	Behaviour halo;


	void Start () {
		tr_Player = GameObject.FindGameObjectWithTag("Player").transform;
	}

	void Update () {
		/* Look at Player */
		transform.rotation = Quaternion.Slerp (transform.rotation
			, Quaternion.LookRotation (tr_Player.position - transform.position)
			, f_RotSpeed * Time.deltaTime);

		/* Move at Player */
		transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
	}
}
