using UnityEngine;
using System.Collections;

public class GoblinArcher : MonoBehaviour {

	public GameObject arrow;

	public void Shoot(){
		Instantiate (arrow,transform.position,Quaternion.identity);
	}
}
