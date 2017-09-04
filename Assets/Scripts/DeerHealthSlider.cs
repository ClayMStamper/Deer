using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeerHealthSlider : MonoBehaviour {

	Slider healthSlider;
	Text healthText;
	public static DeerHealthSlider instance;

	void Awake(){
		if (instance == null) {
			instance = this;
		} else {
			Destroy (this);
		}
	}

	public static DeerHealthSlider GetInstance(){
		return instance;
	}

	void Start () {
		healthSlider = GetComponent <Slider> ();
		healthText = GetComponentInChildren <Text> ();
		healthSlider.maxValue = Deer.GetInstance().maxHealth;
		healthSlider.value = Deer.GetInstance().maxHealth;
		healthText.text = Deer.GetInstance().currentHealth + " / " + Deer.GetInstance().maxHealth;
	}
	public void UpdateHealth(){
		healthSlider.value = Deer.GetInstance().currentHealth;
		healthText.text = Deer.GetInstance().currentHealth + " / " + Deer.GetInstance().maxHealth;
	}
}
