using UnityEngine;
using System.Collections;

public class Head : MonoBehaviour {

	GameObject neck;
	public GameObject body;
	float jumpPower;
	public static bool canJump = true;
	public float jumpCooldown;

	void Start(){
		neck = GameObject.Find ("Neck");
		StartCoroutine (JumpCooldown ());
	}

	void Update () {
		if (transform.position.x > neck.transform.position.x) {
			//return;
		}
		Vector3 newPos = new Vector3 (Mathf.Clamp (transform.position.x, neck.transform.position.x, 7.6f), 
									  Mathf.Clamp (transform.position.y, -4f, 4.81f), 0);
		transform.position = newPos;
	}
	void OnMouseUp(){
		float dist;
		dist = Mathf.Sqrt ((body.transform.position.x - transform.position.x) * (body.transform.position.x - transform.position.x) +
		(body.transform.position.y - transform.position.y * (body.transform.position.y - transform.position.y)));
		print (dist);
		jumpPower = dist;
		if (jumpPower > 0 && canJump == true) { //jump
			canJump = false;
			Movement.velocity.y += jumpPower;
		}
	}

	IEnumerator JumpCooldown(){
		while (true) {
			canJump = true;
			yield return new WaitForSeconds (jumpCooldown);
		}
	}
}
