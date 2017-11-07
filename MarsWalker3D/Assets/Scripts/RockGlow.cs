using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGlow : MonoBehaviour {
	bool clickable;
	Renderer rend;

	GameObject rover;
	void Start () {
		rover = GameObject.FindGameObjectWithTag("Rover");
		rend = GetComponent<Renderer>();
		clickable = gameObject.tag == "Clickable";
		if(!clickable){
			rend.material.SetColor("_RimColor", Color.black);
			rend.material.SetColor("_ColorTint",Color.white);
		} else{
			rend.material.SetFloat("_RimPower", 6);
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(!clickable)
			return;
		float distance = Vector3.Distance(rover.transform.position, transform.position);
		if(distance > 60)
			return;
		rend.material.SetFloat("_RimPower", Mathf.Max(1, distance / 10));
	}
}
