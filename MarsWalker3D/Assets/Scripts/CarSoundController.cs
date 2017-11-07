using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSoundController : MonoBehaviour {

	public Rigidbody rb;
	public AudioSource[] sources;

	float pitch, volume;
	
	// Update is called once per frame
	void Update () {
		float velocity = Mathf.Min(Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.z), 10);
		if(velocity <= 0 && !Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.S))
			volume = 0;
		pitch = Mathf.Min(velocity / 6, 1.5f);
		volume = velocity / 6;
		foreach(AudioSource source in sources){
			source.volume = volume;
			source.pitch = pitch;
		}
	}
}
