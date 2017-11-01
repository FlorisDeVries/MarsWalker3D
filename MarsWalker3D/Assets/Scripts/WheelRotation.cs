using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour {

	public Rigidbody rb;

	public void Update()
	{
		transform.RotateAround(transform.position, rb.transform.right, Mathf.Min(3 * Mathf.Min(rb.velocity.x) + Mathf.Abs(rb.velocity.z), 8));

	}
}
