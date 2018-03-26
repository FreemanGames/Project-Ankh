using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	public GameObject gameController;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider other){
		
		Debug.Log ("Checkpoint was touched by..." + other.gameObject.name);
		
		if (other.gameObject.tag == "Player") {
			Debug.Log ("Touched by player!");
			gameController.GetComponent<CheckPointSystem>().checkPoint = transform;
		}
	}
}
