using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour {

	public Rigidbody rb;

	public void Update()
	{
		transform.RotateAround(transform.position, rb.transform.right, 1f);
	}
}
