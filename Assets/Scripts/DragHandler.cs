using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour {

	void OnMouseDrag(){
		Vector3 curPos = new Vector3  (Input.mousePosition.x, Input.mousePosition.y);
		Vector3 worldPos = Camera.main.ScreenToWorldPoint (curPos);
		worldPos.z = 0;
		transform.position = worldPos;
	}
}
