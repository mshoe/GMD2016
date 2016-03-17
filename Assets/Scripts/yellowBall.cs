using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class yellowBall : MonoBehaviour {

	public GameObject player;
	public GameObject winDetector;

	Behaviour halo;

	public float speed;
	public float RotSpeed;
	public float direction;

	public float stop;

	public Vector3 offset;
	public Vector3 unitOffset;

	public Slider slider;

	void Start () {
		//offset = transform.position - player.transform.position;
		direction = -1f;
		halo = (Behaviour)GetComponent ("Halo");
		halo.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		
		stop += 1;
		if (Input.GetKeyDown (KeyCode.Space)) {
			direction *= -1;
			halo.enabled = !halo.enabled;
		}

		if (stop > 30) {
			offset = transform.position - player.transform.position;
			offset.y = 0;
			unitOffset = offset * (1f / offset.magnitude);
			transform.position -= unitOffset * speed * direction * Time.deltaTime;
			if (stop % 120 == 0) {
				slider.value -= 4;
			}
			if (slider.value <= 0) {
				Application.LoadLevel ("gameOver");
			}
		}
	}


	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.CompareTag ("enemy")) {
			Destroy (col.gameObject);
			winDetector.GetComponent<WinDetector>().score += 1;
			if (slider.value < 100) {
				slider.value += 4;
			}
		} 
		else if (col.gameObject.CompareTag ("Player")) {
			Application.LoadLevel ("gameOver");
		} else if (col.gameObject.CompareTag ("goodGuy")) {
			Application.LoadLevel ("gameOver");
		}
	}
}
