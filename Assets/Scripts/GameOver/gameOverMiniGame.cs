using UnityEngine;
using System.Collections;

public class gameOverMiniGame : MonoBehaviour {

	public GameObject WinDetector;
	public GameObject Music;


	void Start () {
		WinDetector = GameObject.Find ("WinDetector");
		Music = GameObject.Find ("Music");
	}
	
	public void playAgainMiniGame()
	{
		Destroy (WinDetector);
		Destroy (Music);
		Application.LoadLevel ("minigame");
	}

	public void mainMenu()
	{
		Destroy (WinDetector);
		Destroy (Music);
		Application.LoadLevel ("mainMenu");
	}

	public void playAgainYellowBall()
	{
		Destroy (WinDetector);
		Destroy (Music);
		Application.LoadLevel ("yellowMode");
	}
}
