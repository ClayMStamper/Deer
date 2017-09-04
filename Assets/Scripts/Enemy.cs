using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float health, contactDamage;
	public GameObject EnemyHealthSliderPrefab;
	GameObject myHealthSlider;

	void Start(){
		myHealthSlider = Instantiate (EnemyHealthSliderPrefab) as GameObject;
		myHealthSlider.transform.SetParent (GameObject.Find ("Canvas").transform);
		myHealthSlider.transform.localScale = new Vector2 (GetComponent <PolygonCollider2D> ().bounds.size.x, 1);
		myHealthSlider.GetComponent <Slider>().maxValue = health;
		myHealthSlider.GetComponent <Slider>().value = health;
	}
	void FixedUpdate(){
		Vector3 newPos = new Vector3 (transform.position.x,	transform.position.y + (GetComponent <PolygonCollider2D> ().bounds.size.y / 2) + 0.2f );
		myHealthSlider.transform.position = newPos;
	}
		
	public void UpdateHealth(float damageTaken){
		health -= damageTaken;
		myHealthSlider.GetComponent <Slider>().value = health;
		if (health <= 0) {
			Destroy (gameObject);
		}
	}
}
