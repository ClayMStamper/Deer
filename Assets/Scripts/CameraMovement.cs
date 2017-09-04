using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	public float offset;
	public GameObject body;

	void Update () {
		float newX = body.transform.position.x;
		Vector3 newPos = new Vector3 (newX + offset, transform.position.y, transform.position.z);
		transform.position = newPos;
	}
}
