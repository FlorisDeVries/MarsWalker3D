using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour {

	public Rigidbody rb;

	public void Update()
	{
		int direction = rb.transform.InverseTransformDirection(rb.velocity).z > 0 ? 1 : -1;
		transform.RotateAround(transform.position, rb.transform.right, direction * Mathf.Min(3 * Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.z), 8));
	}
}
