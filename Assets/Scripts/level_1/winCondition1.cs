using UnityEngine;
using System.Collections;

public class winCondition1 : MonoBehaviour {

	public GameObject WinDetector;

	void Start () {
		WinDetector = GameObject.Find ("WinDetector");
	}
	
	// Update is called once per frame
	void Update () {
		if (WinDetector.GetComponent<WinDetector> ().score == 1) {
			Application.LoadLevel ("level_2");
		}
	}

}
