﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverMovement : MonoBehaviour {
	
	public List<AxleInfo> axleInfos;
	public float maxMotorTorque;
	public float maxSteeringAngle;
	public float breakTorque;

	private Vector3 centerOfMassOffset =  new Vector3(0,-.5f,0);
	public Rigidbody rb;

	void Start() {
		//rb.centerOfMass += centerOfMassOffset;
	}
	void FixedUpdate() {
		float motor = maxMotorTorque * Input.GetAxis("Move");
		float steering = maxSteeringAngle * Input.GetAxis("Turn");

		foreach (AxleInfo axleInfo in axleInfos){
				if (axleInfo.steering) {
                    axleInfo.leftWheel.steerAngle = steering;
                    axleInfo.rightWheel.steerAngle = steering;
                }
                if (axleInfo.motor) {
                    axleInfo.leftWheel.motorTorque = motor;
                    axleInfo.rightWheel.motorTorque = motor;
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