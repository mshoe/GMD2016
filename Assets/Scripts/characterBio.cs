using UnityEngine;
using System.Collections;

public class characterBio : MonoBehaviour {

	public void ArcadeMode ()
	{
		Application.LoadLevel ("minigame");
	}

	public void YellowMode ()
	{
		Application.LoadLevel ("yellowMode");
	}
}

