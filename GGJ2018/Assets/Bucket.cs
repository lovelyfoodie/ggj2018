using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Bucket : MonoBehaviour {

	//TODO: Take in gate collider object in the 

	private Color BLUE = Color.blue;
	private Color RED = Color.red;
	private bool isBlue = false;

	public GameObject gate;
	private SpriteRenderer gateSprite;


	// Use this for initialization
	void Start () {
		gateSprite = gate.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1") && isBlue) {
			gateSprite.color = RED;
			gate.layer = 8;
			isBlue = false;
		} else if(Input.GetButtonDown ("Fire1") && !isBlue) {
			gateSprite.color = BLUE;
			gate.layer = 9;
			isBlue = true;
		}
		
	}
}
