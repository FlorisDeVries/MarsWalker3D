using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour {

	public float range;
	public Camera camera;
	public GameController controller;
	public ResearchProgress researchProgress;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetMouseButtonDown(0)){ 
			Ray ray = camera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit, range))
				if(hit.collider.tag == "Clickable"){
					var collider = hit.collider;
					var clickable = collider.GetComponent<ClickAble>();
					clickable.OnClick();
					researchProgress.ResearchRock();
			}
		}
	}
}
