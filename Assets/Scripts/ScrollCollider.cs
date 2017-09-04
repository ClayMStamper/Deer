using UnityEngine;
using System.Collections;

public class ScrollCollider : MonoBehaviour {

	float width, numSiblings;

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Enemy" || col.tag == "Missile") {
			print (col.tag);
			Destroy (col.gameObject);
			return;
		}
		width = col.GetComponent <BoxCollider2D> ().size.x;
		numSiblings = col.transform.parent.childCount;
//		print (width + "   " + numSiblings);
		Vector3 offset = new Vector3 (width * numSiblings,0,0);
		col.transform.Translate (offset);
	}
}
