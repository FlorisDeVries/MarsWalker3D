using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogCreator : MonoBehaviour {

	public float density;
	public float distance;

	void Start () {
		RenderSettings.fog = true;
		RenderSettings.fogDensity = density;
		RenderSettings.fogStartDistance = distance;
	}
	
	void Update () {
		
	}
}
