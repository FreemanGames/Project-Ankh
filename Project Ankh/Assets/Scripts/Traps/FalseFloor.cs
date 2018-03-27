using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FalseFloor : MonoBehaviour
{

	public int damage = 1;
	public MeshRenderer floorRenderer;
	private bool triggered = false;
	private NavMeshObstacle mNavMeshObstacle;
	public GameObject playerDead;
	public float respawnDelayTime = 2f;


	void Start ()
	{
		mNavMeshObstacle = GetComponent<NavMeshObstacle> ();
	}



	void OnTriggerEnter (Collider other)
	{
		// if false floor is touched by player
		if ((other.tag == "Player") && triggered == false) {

			if (other.GetComponent<PlayerHealth> ().health > 0f) {

				// hide player model
				other.GetComponentInChildren<SkinnedMeshRenderer> ().enabled = false;

				//stop the player moving
				other.GetComponentInChildren<NavMeshAgent> ().isStopped = true;

				// spawn dead player model
				Instantiate (playerDead, transform.position, Quaternion.identity);

				// make floor tile disappear
				floorRenderer.enabled = false;
				GetComponent<Collider> ().enabled = false;  // disable floor collider, so player falls through

				other.GetComponentInChildren<PlayerHealth> ().ReactivatePlayer (respawnDelayTime);

				mNavMeshObstacle.enabled = true;
				mNavMeshObstacle.carving = enabled;

				triggered = true;
			}
		}
	}



}