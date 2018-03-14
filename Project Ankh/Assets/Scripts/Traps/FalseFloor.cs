using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseFloor : MonoBehaviour {

		void Start () {

		}
		void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {	
			Destroy (this.gameObject);
		}
		}
	}