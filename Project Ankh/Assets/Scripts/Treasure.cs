using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour {

	public int pointsToGive = 100;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hit; {
			GetComponent<ScoreSystem>().AddScore(pointsToGive);

		//if (Input.GetMouseButtonDown (0)) {
			//if (Physics.Raycast (ray, out hit, 20))
		}
	}
}
