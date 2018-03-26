using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDamage : MonoBehaviour {

	public int damage = 1;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, 4F);
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			other.GetComponent<PlayerHealth>
			().TakeDamage (damage);


		}
		Destroy (this.gameObject);
	}
}