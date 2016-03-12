using UnityEngine;
using System.Collections;

public class level5UnFaithfulGrass : MonoBehaviour {

	public GameObject mouse;
	public GameObject player;
	public Vector3 offset;

	void Start () {
		offset = transform.position - player.transform.position;
	}


	// Update is called once per frame
	void Update () {
		offset = transform.position - player.transform.position;
		if (offset.magnitude < 6) {
			mouse.GetComponent<mouseAI> ().direction = -2f;
		} else {
			mouse.GetComponent<mouseAI> ().direction = 1f;
		}
	}
}
