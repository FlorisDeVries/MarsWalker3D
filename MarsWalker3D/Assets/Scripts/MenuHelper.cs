using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHelper : MonoBehaviour {

	public Transform menu;
	public Transform howToPlay;
	public void StartGame(){
		SceneManager.LoadScene("MainGame");
	}

	public void MainMenu(){
		SceneManager.LoadScene("MainMenu");
		AudioListener.volume = 1;
		Time.timeScale = 1;
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
