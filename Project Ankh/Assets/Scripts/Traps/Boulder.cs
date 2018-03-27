using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Boulder : MonoBehaviour
{

	public int damage = 1;
	public GameObject wall;
	public float respawnDelayTime = 3f;

	void OnTriggerEnter (Collider other)
	{
		// if ball touches player
		if (other.tag == "Player") {

			if (other.GetComponent<PlayerHealth> ().health > 0f) {

				// hide player model & collider
				other.GetComponentInChildren<SkinnedMeshRenderer> ().enabled = false;
				other.GetComponent<Collider> ().enabled = false;

				//stop the player moving
				other.GetComponentInChildren<NavMeshAgent> ().isStopped = true;

				// spawn blood particles
				//Instantiate (bloodParticles, other.gameObject.transform.position, Quaternion.identity);

				other.GetComponentInChildren<PlayerHealth> ().ReactivatePlayer (respawnDelayTime);

			}
		}
	}






	void Safe (Collider other)
	{
		if (other.tag == "BreakableWall") {
			wall.SetActive (false);
			Debug.Log ("bleh");
		}
	}

}