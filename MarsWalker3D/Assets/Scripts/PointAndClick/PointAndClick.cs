using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour {

	public float range;
	public Camera cam;
	public ResearchProgress researchProgress;
	public Transform rover;
	
	void Update () {
		if (Input.GetMouseButtonDown(0)){ 
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
				if(hit.collider.tag == "Clickable" && Vector3.Distance(rover.position, hit.collider.transform.position) < range){
					var collider = hit.collider;
					var clickable = collider.GetComponent<ClickAble>();
					clickable.OnClick();
					researchProgress.ResearchRock();
			}
		}
	}
}
