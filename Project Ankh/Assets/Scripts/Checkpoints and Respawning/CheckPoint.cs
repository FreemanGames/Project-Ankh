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
		if (other.gameObject.tag == "Player") {
			gameController.GetComponent<CheckPointSystem>().checkPoint = transform;
		}
	}
}
