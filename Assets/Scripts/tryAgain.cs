using UnityEngine;
using System.Collections;

public class tryAgain : MonoBehaviour {

	void OnGUI () {
		if (GUILayout.Button ("Try Again")) {
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
