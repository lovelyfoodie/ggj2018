using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bucket1 : MonoBehaviour {

	//Todo: Get Collider object from the bucket
	// onTriggerEnter2d to determine the cell/item that came into the bucket
	// update the cell/item count based on what came in
	// update the ui based on the count

	private BoxCollider2D collider; 
	[SerializeField]
	public Ojbective [] playerObjectives;
	private int currObjectiveIndex = 0;
	public int redCount = 0; 
	public int blueCount = 0;


	// Use this for initialization
	void Start () {
		collider = GetComponent<BoxCollider2D> ();
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
	}

	void CheckIfObjectiveComplete(){
		int _neededBlue = playerObjectives [currObjectiveIndex].blueCount;
		int _neededRed = playerObjectives [currObjectiveIndex].redCount;
		int blueLeft = Mathf.Clamp (_neededBlue - blueCount,0,999);
		int redLeft = Mathf.Clamp(_neededRed - redCount,0,999);
		if (blueLeft == 0 && redLeft == 0) {
			Debug.Log ("Objective " + currObjectiveIndex + " Complete");
			UpdateUI (blueLeft, redLeft, true);
		}
		UpdateUI (blueLeft,redLeft,false);
	}
}
