using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

	public Transform canvasPause;
	public Transform canvasHUD;
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			Pause();
		}
	}


	public void Pause(){
		canvasPause.gameObject.SetActive(!canvasPause.gameObject.activeInHierarchy);
		canvasHUD.gameObject.SetActive(!canvasHUD.gameObject.activeInHierarchy);

		Time.timeScale = Time.timeScale == 1 ? 0 : 1;
		AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;
	}

}
