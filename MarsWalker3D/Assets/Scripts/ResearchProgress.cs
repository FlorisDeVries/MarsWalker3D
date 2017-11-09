using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResearchProgress : MonoBehaviour {

	int nRocks;
	int progress;
	public Slider progressSlider;
	public Image progressImage;
	public AudioSource playerAudio;
	public PointAndClick pointAndClick;
	public RoverMovement roverMovement;
	public Canvas victory, HUD;

	bool researched;
	bool researchDone;

	public float flashSpeed;
	public Color flashColor = new Color(255, 255 ,10);
	void Start () {
		GameObject[] gol = GameObject.FindGameObjectsWithTag("Clickable");
		nRocks = gol.Length;
		progress = 0;
		progressSlider.maxValue = nRocks;
		nRocks = 1;
	}
	
	void Update () {
		if(researched)
			progressImage.color = flashColor;
		else
			progressImage.color = Color.Lerp(progressImage.color, Color.clear, flashSpeed * Time.deltaTime);
		
		researched = false;
	}

	public void ResearchRock(){
		researched = true;
		progress++;
		progressSlider.value = progress;
		
		if(progress >= nRocks && !researchDone)
			CompleteResearch();
	}

	void CompleteResearch(){
		researchDone = true;

		playerAudio.Play();
		progressSlider.value = progressSlider.maxValue;

		pointAndClick.enabled = false;
		roverMovement.finished = true;
		
		victory.gameObject.SetActive(true);
		HUD.gameObject.SetActive(false);
	}
}
