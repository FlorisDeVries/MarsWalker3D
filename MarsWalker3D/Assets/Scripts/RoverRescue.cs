using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverRescue : MonoBehaviour {

	public AudioSource source;

	void OnDestroy()
	{
		source.Stop();
	}
}
