using UnityEngine;
using System.Collections;

public class Rope : MonoBehaviour {

	internal Rigidbody2D rBody;

	internal void Start(){
		rBody = GetComponent <Rigidbody2D> ();

		int childCount = transform.childCount;

		for (int i = 0; i < childCount; i++) {
			Transform t = transform.GetChild (i);
			t.gameObject.AddComponent <HingeJoint2D> ();
			t.gameObject.AddComponent <Rigidbody2D> ();

			HingeJoint2D hinge = t.gameObject.GetComponent <HingeJoint2D> ();
			hinge.connectedBody = 
				i == 0 ? rBody :
				transform.GetChild (i - 1).GetComponent <Rigidbody2D> ();
			
		}
	}
}
