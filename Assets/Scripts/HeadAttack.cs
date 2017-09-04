using UnityEngine;
using System.Collections;

public class HeadAttack : MonoBehaviour {

	public float damage;

	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Enemy")) {
			col.GetComponent <Enemy> ().UpdateHealth (damage);
		}
		if (col.CompareTag("Missile")){
			Destroy (col.gameObject);
		}
	}
}
