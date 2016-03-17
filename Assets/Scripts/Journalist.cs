using UnityEngine;
using System.Collections;

public class Journalist : MonoBehaviour {

	public GameObject player;

	public float speed;
	public float RotSpeed;
	public float direction;

	public float stop;

	public Vector3 offset;
	public Vector3 unitOffset;

//	public Vector3 offset2;
//	public Vector3 unitOffset2;
//
//	public bool YellowBall;

	void Start () {
		//offset = transform.position - player.transform.position;
		direction = 1f;
//		YellowBall = false;
	}

	// Update is called once per frame
	void Update () {
		stop += 1;
		if (stop > 30) {
//			if (Input.GetKeyDown (KeyCode.Space)) {
//				YellowBall = !YellowBall;
//			}
//			if (YellowBall) {
//				offset2 = transform.position - yB.transform.position;
//				unitOffset2 = offset2 * (1f / offset2.magnitude);
//				transform.position -= unitOffset2 * speed * direction * Time.deltaTime;
//			} else {
				offset = transform.position - player.transform.position;
				unitOffset = offset * (1f / offset.magnitude);
				transform.position -= unitOffset * speed * direction * Time.deltaTime;
			//}
		}
	}
}