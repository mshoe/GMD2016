using UnityEngine;
using System.Collections;

public class cubeChange : MonoBehaviour {

	public bool morph1 = false;
	int time;
	Behaviour Morph;

	void Start () {
		//time = 0;
		Morph = (Behaviour)GetComponent ("Animator");
		Morph.enabled = false;
//		anim = GetComponent<Animator>();
	}
	
	void morph_1 () {
		//transform.localScale = new Vector3 (Random.Range((int)1,(int)3), Random.Range((int)2, (int)3), Random.Range((int)1,(int)3));
		Morph.enabled = true;
		//time = 55;
//		anim.Play("growingCube");
		morph1 = false;
	}

	void Update () {
		//if (time > 0) {
		//	time -= 1;
		//}
		if (morph1 == true) {
			morph_1 ();
		}
		//if (time <= 0) {
				//transform.localScale = new Vector3 (1, 1, 1);
			//Morph.enabled = false;
		//}
	}
}
