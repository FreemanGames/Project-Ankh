using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FalseFloor : MonoBehaviour {

	public int damage = 1;
	public MeshRenderer floorRenderer;
	private bool triggered = false;
	private NavMeshObstacle mNavMeshObstacle;

		void Start () {
		mNavMeshObstacle = GetComponent<NavMeshObstacle> ();
		}

	void OnTriggerEnter(Collider other){
		if ((other.tag == "Player") && triggered == false) {
			other.GetComponent<PlayerHealth>
			().TakeDamage (damage);
		}
		floorRenderer.enabled = false;
		mNavMeshObstacle.enabled = true;
		mNavMeshObstacle.carving = enabled;
		triggered = true;
	}
	}