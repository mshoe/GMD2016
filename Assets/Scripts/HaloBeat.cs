using UnityEngine;
using System.Collections;

public class HaloBeat : MonoBehaviour {

	public Behaviour halo;
	public float haloSize;

	void Start () {
		halo = (Behaviour)GetComponent ("Halo");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
