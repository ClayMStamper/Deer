using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public static float speed;
	public float gravityMod;
	public static Vector3 velocity, gravity;
	Animator animator;
	GameObject neck, head, torso;

	// Use this for initialization
	void Start () {
		//neck = GameObject.Find ("Neck");
		head = GameObject.Find ("Head");
		torso = GameObject.Find ("Torso");
		animator = torso.GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		gravity.y = gravityMod;
		speed = 6f - head.transform.position.x; //- neck.transform.position.x;
		animator.speed = Mathf.Sqrt (speed)/2;
		if (transform.localPosition.y > 0) {
			animator.speed = .2f; // jump animation
		}
		velocity += gravity * Time.deltaTime;
		velocity.x *= speed;
		if (transform.localPosition.y <= 0) {
			if (velocity.y <= 0) {
				velocity.y = 0;
			}
			transform.localPosition = new Vector3 (transform.localPosition.x, 0);
		}
		if (transform.localPosition.y >= 27) {
			if (velocity.y >= 0) {
				velocity.y = 0;
			}
		}
		transform.position += velocity * Time.deltaTime; 
		Vector3 clampedPos = new Vector3 (transform.localPosition.x, Mathf.Clamp (transform.localPosition.y, 0, 27));
		transform.localPosition = clampedPos;
	}
}
