using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class YellowMode : MonoBehaviour {

	public GameObject winDetector;

	Behaviour halo;

	public float speed;
	public float direction;

	public int stop;
	public Slider slider;

	void Start () {
		//offset = transform.position - player.transform.position;
		direction = -1f;
		halo = (Behaviour)GetComponent ("Halo");
		halo.enabled = false;
	}

	// Update is called once per frame

	void FixedUpdate ()
	{

		//Movement Physics
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float jump = 0.0f;

		Vector3 finalMovement = new Vector3 (moveHorizontal * speed, 0f, moveVertical * speed);

		transform.position += finalMovement * Time.deltaTime;

		if (stop % 120 == 0) {
			slider.value -= 4;
		}
		if (slider.value <= 0) {
			Application.LoadLevel ("gameOver");
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
		} else if (col.gameObject.CompareTag ("goodGuy")) {
			Application.LoadLevel ("gameOver");
		}
	}
}
