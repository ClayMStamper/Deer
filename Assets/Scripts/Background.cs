using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {

	public float multiplierMod;

	void Update () {
		if (Movement.speed <= 0) {
			return;
		}
		float speedMultiplier = (Mathf.Sqrt (Movement.speed) * multiplierMod);
		transform.Translate (Vector3.left * Time.deltaTime * speedMultiplier);
	}
}
