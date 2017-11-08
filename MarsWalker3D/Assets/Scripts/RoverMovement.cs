using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverMovement : MonoBehaviour {
	
	public List<AxleInfo> axleInfos;
	public float maxMotorTorque;
	public float maxSteeringAngle;
	public float brakeTorque;
	public float maxSpeed;
	public Rigidbody rb;
	public bool finished = false;
	private Vector3 centerOfMassOffset =  new Vector3(0,-.5f,0);

	void Start() {
		rb.centerOfMass += centerOfMassOffset;
	}
	void Update() {
		if(finished){
			foreach (AxleInfo axleInfo in axleInfos)
			{
				axleInfo.leftWheel.brakeTorque = brakeTorque;
				axleInfo.rightWheel.brakeTorque = brakeTorque;
			}
			return;
		}

		float speed = rb.velocity.sqrMagnitude;
		float motor = speed < maxSpeed ? maxMotorTorque * Input.GetAxis("Move") : 0;
		float steering = maxSteeringAngle * Input.GetAxis("Turn");

		foreach (AxleInfo axleInfo in axleInfos){
				if(Input.GetAxis("Brake") == 0){
					if (axleInfo.steering) {
						axleInfo.rightWheel.brakeTorque = 0;
						axleInfo.leftWheel.brakeTorque = 0;
						axleInfo.leftWheel.steerAngle = steering;
						axleInfo.rightWheel.steerAngle = steering;
					}
					if (axleInfo.motor) {
						axleInfo.leftWheel.motorTorque = motor;
						axleInfo.rightWheel.motorTorque = motor;
					}
				} else{
					if(axleInfo.steering){
						axleInfo.rightWheel.brakeTorque = brakeTorque;
						axleInfo.leftWheel.brakeTorque = brakeTorque;
					}
				}
		}
	}
}

[System.Serializable]
public class AxleInfo{
	public WheelCollider leftWheel, rightWheel;

	public bool motor;
	public bool steering;
}