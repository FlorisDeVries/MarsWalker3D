using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndClick : MonoBehaviour {

	public float range;
	public Camera camera;

	void Start () {
		
	}
	
	void Update () {
	if (Input.GetMouseButtonDown(0)){ 
		Ray ray = camera.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, range)){
		// the object identified by hit.transform was clicked
		// do whatever you want
     }
   }
	}
}
