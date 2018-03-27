using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ProjectileDamage : MonoBehaviour {

	public int damage = 1;
	public float respawnDelayTime = 0.5f;

	//public GameObject bloodParticles;

	void Start () {
		Destroy (this.gameObject, 4F);
	}




	void OnTriggerEnter (Collider other)
	{
		// if projectile touches player
		if (other.tag == "Player") {

			if (other.GetComponent<PlayerHealth> ().health > 0f) {

				// hide player model
				other.GetComponentInChildren<SkinnedMeshRenderer> ().enabled = false;

				//stop the player moving
				other.GetComponentInChildren<NavMeshAgent> ().isStopped = true;

				// spawn blood particles
				//Instantiate (bloodParticles, other.gameObject.transform.position, Quaternion.identity);

				other.GetComponentInChildren<PlayerHealth> ().ReactivatePlayer (respawnDelayTime);

				Destroy (this.gameObject);

			}
		}
	}



}