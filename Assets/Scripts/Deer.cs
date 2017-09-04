using UnityEngine;
using System.Collections;

public class Deer : MonoBehaviour {

	public static Deer instance = null;
	public float currentHealth, maxHealth;

	void Awake(){
		if (instance == null) {
			instance = this;
		} else {
			Destroy (this);
		}
	}
	public static Deer GetInstance(){
		return instance;
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
