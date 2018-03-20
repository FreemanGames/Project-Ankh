using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure : MonoBehaviour {

	public int pointsToGive = 100;
	public float scoreIncrease;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit; {
			if (Input.GetMouseButtonDown(0)){ // if left button pressed...
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				RaycastHit collider;
				if (Physics.Raycast(ray, out hit)){
					//Debug.Log ("bleh");
					other.GetComponent<ScoreSystem>().AddScore(scoreIncrease);

		}
	}
}
}
}
