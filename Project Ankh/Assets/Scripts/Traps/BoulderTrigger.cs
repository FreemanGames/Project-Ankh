using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderTrigger : MonoBehaviour {

	public GameObject boulderGuard;

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			boulderGuard.SetActive(false);
			Debug.Log ("bleh");
		}
	}
}