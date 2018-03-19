using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour {

	public int damage = 1;
	public GameObject wall;

	void Start () {
	}
	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			other.GetComponent<PlayerHealth>
			().TakeDamage (damage);
		}
	}
	void Safe (Collider other){
		if (other.tag == "BreakableWall") {
			Debug.Log ("bleh");
			wall.SetActive(false);
		}
}
}