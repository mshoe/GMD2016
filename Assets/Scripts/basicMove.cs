using UnityEngine;
using System.Collections;

public class basicMove : MonoBehaviour {

	public GameObject player;

	public float speed;
	public float RotSpeed;
	public float direction;

	public float stop;

	public Vector3 offset;
	public Vector3 unitOffset;

	void Start () {
		//offset = transform.position - player.transform.position;
		direction = 1f;
	}

	// Update is called once per frame
	void Update () {
		stop += 1;
		if (stop > 30) {
			offset = transform.position - player.transform.position;
			unitOffset = offset * (1f / offset.magnitude);
			transform.position -= unitOffset * speed * direction * Time.deltaTime;
		}
	}
}