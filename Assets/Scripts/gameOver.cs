using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {

	public Texture gameOverTexture;
	public GameObject WinDetector;
	public GameObject Music;
	public int score;
	public int displayScore;

	void Start () {
		WinDetector = GameObject.Find ("WinDetector");
		Music = GameObject.Find ("Music");
		score = WinDetector.GetComponent<WinDetector>().score;
		displayScore = score;
		score = 0;
	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),gameOverTexture);
		GUI.TextArea (new Rect (0, 0, Screen.width/4, Screen.height/4), "Score: " + displayScore);
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height /2, 150, 25),"Play Again")) 
		{
			Destroy (WinDetector);
			Destroy (Music);
			Application.LoadLevel("minigame");
		}
		if (GUI.Button(new Rect(Screen.width / 2, Screen.height /2 + 25, 150, 25),"Main Menu")) 
		{
			Destroy (WinDetector);
			Destroy (Music);
			Application.LoadLevel("mainMenu");
		}
	}
}
