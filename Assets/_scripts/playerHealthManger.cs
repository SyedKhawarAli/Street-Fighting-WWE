using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealthManger : MonoBehaviour {

public float playerHealth = 10f;

public  Slider healthSlider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void getDamage(float damage){
		playerHealth -= damage;
		healthSlider.value = playerHealth/10;
	}

	public bool isAlive(){
		if (playerHealth <= 0 )
		{
			return false;
		}else
		{
			return true;
		}
	}


}
