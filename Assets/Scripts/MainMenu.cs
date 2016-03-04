using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture mainMenuTexture;

	void Start () {

	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),mainMenuTexture);
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height /2 -25, 150, 25),"Story Mode")) 
		{
			Application.LoadLevel("level_1");
		}
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height /2, 150, 25),"Arcade")) 
		{
			Application.LoadLevel("minigame");
		}
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height /2 + 25, 150, 25),"ggwp")) 
		{
			Application.Quit();
		}
	}
}
