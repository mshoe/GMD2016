using UnityEngine;
using System.Collections;

public class mouseAI : MonoBehaviour {

	public GameObject player;

	public float speed;

	public Vector3 offset;
	public Vector3 unitOffset;

	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		offset = transform.position - player.transform.position;
		unitOffset = offset * (1f/offset.magnitude);
		transform.position -= unitOffset * speed * Time.deltaTime;
	}
}
