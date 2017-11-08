using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {
	public Transform rover;
	public Camera camera;
	public float speed;

	void Update () {
		camera.transform.LookAt(rover);
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
		speed += Random.Range(0,2) == 1 ? .1f : -.1f;
		speed = Mathf.Clamp(speed, 5, 15);
	}
}
