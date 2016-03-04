using UnityEngine;
using System.Collections;

public class mainMenuScript : MonoBehaviour {

	public void ArcadeMode ()
	{
		Application.LoadLevel ("minigame");
	}

	public void StoryMode ()
	{
		Application.LoadLevel ("level_1");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
