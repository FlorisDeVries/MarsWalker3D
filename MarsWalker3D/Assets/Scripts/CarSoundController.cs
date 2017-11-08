using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSoundController : MonoBehaviour {

	public Rigidbody rb;
	public AudioSource[] sources;

	public float maxPitch, maxVolume;

	float pitch, volume, tempPitch;
	
	private void Start() {
		tempPitch = maxPitch;
	}
	// Update is called once per frame
	void Update () {
		float velocity = Mathf.Min(Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.z), 10);
		if(velocity <= 0 && !Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.S))
			volume = 0;

		if(velocity/6 < maxPitch){
			pitch = velocity / 6;
			tempPitch = maxPitch;
		} else {
			tempPitch += Random.Range(0, 2) == 1 ? .01f : -.01f;
			tempPitch = Mathf.Clamp(tempPitch, maxPitch, velocity/6);
			pitch = tempPitch;
		}
		volume = Mathf.Min(velocity / 6, maxVolume);
		foreach(AudioSource source in sources){
			source.volume = volume;
			source.pitch = pitch;
		}
	}
}
