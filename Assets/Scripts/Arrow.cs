using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {

	public float speed = 9;
	public float damage;

	void FixedUpdate () {
		transform.Translate (Vector3.left * Time.deltaTime * speed * (1 + Movement.speed/4));
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "DeerBody") {
			Deer.GetInstance().currentHealth -= damage;
			DeerHealthSlider.GetInstance ().UpdateHealth ();
			Destroy (gameObject);
		}
	}
}
