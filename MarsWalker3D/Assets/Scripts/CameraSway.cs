using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSway : MonoBehaviour {
	public Transform target;
    public float rotationDamping;
    public float heightDamping;

	public float setDistance, setHeight;
	public float distance, height;
    private float wantedRotationAngle;
    private float wantedHeight;
    private float currentRotationAngle;
    private float currentHeight;
    private Quaternion currentRotation;

	void Start(){
		distance = setDistance;
		height = setHeight;
	}
    void Update () {
		if(!target) 
			return;

		// Calculate the current rotation angles
		wantedRotationAngle = target.eulerAngles.y;
		wantedHeight = target.position.y + height;
		currentRotationAngle = transform.eulerAngles.y;
		currentHeight = transform.position.y;
		// Damp the rotation around the y-axis
		currentRotationAngle = Mathf.LerpAngle (currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
		// Damp the height
		currentHeight = Mathf.Lerp (currentHeight, wantedHeight, heightDamping * Time.deltaTime);
		// Convert the angle into a rotation
		currentRotation = Quaternion.Euler (0, currentRotationAngle, 0);
		// Set the position of the camera on the x-z plane to:
		// distance meters behind the target
		transform.position = target.position;
		transform.position -= currentRotation * Vector3.forward * distance;
		// Set the height of the camera
		transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
		// Always look at the target
		transform.LookAt (target);
	}
}
