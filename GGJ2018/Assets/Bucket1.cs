﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Events;

public class Bucket1 : MonoBehaviour {

	//Todo: Get Collider object from the bucket
	// onTriggerEnter2d to determine the cell/item that came into the bucket
	// update the cell/item count based on what came in
	// update the ui based on the count

	private BoxCollider2D collider; 
	[SerializeField]
	public Ojbective [] playerObjectives = new Ojbective[5];
	public String playerName; 
	public Text remainingBlues;
	public Text remainingReds;
	private int currObjectiveIndex = 0;
	public int redCount = 0; 
	public int blueCount = 0;
	public UnityEvent OnObjectiveComplete;
	public Objectives_Collection objectivesCollection;


	// Use this for initialization
	void Start () {
		collider = GetComponent<BoxCollider2D> ();
		for (int i = 0; i < playerObjectives.Length; i++) {
			playerObjectives [i] = objectivesCollection.getRandom ();
		}
		Ojbective tempObjective = playerObjectives [currObjectiveIndex];
		UpdateUI (tempObjective.blueCount, tempObjective.redCount, false);
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.layer == 8) {
			redCount++;
		} else if (other.gameObject.layer == 9) {
			blueCount++;
		}
		CheckIfObjectiveComplete ();
	}

	void UpdateUI(int _blueLeft, int _redLeft, bool complete){
		remainingBlues.text = _blueLeft.ToString ();
		remainingReds.text = _redLeft.ToString ();
		if (complete) {
			redCount = 0;
			blueCount = 0;
			if (currObjectiveIndex == playerObjectives.Length - 1) {
				Debug.Log (playerName + " wins!");
				OnObjectiveComplete.Invoke ();
			} else {
				currObjectiveIndex++;
				Ojbective tempObjective = playerObjectives [currObjectiveIndex];
				remainingBlues.text = tempObjective.blueCount.ToString ();
				remainingReds.text = tempObjective.redCount.ToString ();
			}
		}
	}

	void CheckIfObjectiveComplete(){
		int _neededBlue = playerObjectives [currObjectiveIndex].blueCount;
		int _neededRed = playerObjectives [currObjectiveIndex].redCount;
		int blueLeft = Mathf.Clamp (_neededBlue - blueCount,0,999);
		int redLeft = Mathf.Clamp(_neededRed - redCount,0,999);
		if (blueLeft == 0 && redLeft == 0) {
			Debug.Log ("Objective " + currObjectiveIndex + " Complete");
			UpdateUI (blueLeft, redLeft, true);
		} else {
			UpdateUI (blueLeft, redLeft, false);
		}
	}
}
