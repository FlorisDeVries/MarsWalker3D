using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningSound : MonoBehaviour {

	public float speed;

	private void Update() {
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
		speed += Random.Range(0,2) == 1 ? 1 : -1;
		Mathf.Clamp(speed, -50, 50);
	}
}
