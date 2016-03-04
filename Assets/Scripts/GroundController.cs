using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {

	public GameObject[] movingGroundCubes;
	int time;
	int i;

	void Start () {
		movingGroundCubes = GameObject.FindGameObjectsWithTag ("ground");
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time += 1;
		if (time % 55 == 0) {
			movingGroundCubes [Random.Range ((int)0, movingGroundCubes.Length)].GetComponent<cubeChange>().morph1 = true;
		}
	}
}
