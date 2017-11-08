using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHelper : MonoBehaviour {

	public Transform menu;
	public Transform howToPlay;
	public void StartGame(){
		Application.LoadLevel("MainGame");
	}

	public void MainMenu(){
		Application.LoadLevel("MainMenu");
	}

	public void QuitGame(){
		Application.Quit();
	}
	public void HowToPlay(){
		menu.gameObject.SetActive(false);
		howToPlay.gameObject.SetActive(true);
	}

	public void QuitHowToPlay(){
		menu.gameObject.SetActive(true);
		howToPlay.gameObject.SetActive(false);
	}
}
