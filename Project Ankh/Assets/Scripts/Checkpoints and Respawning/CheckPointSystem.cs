using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointSystem : MonoBehaviour {

	public int lives = 3; 
	public GameObject player;
	public Transform spawnPoint;
	public Transform checkPoint;


	// Use this for initialization
	void Start () {
		
	}

	public void RespawnPlayer()
	{
		player.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
		player.transform.position = checkPoint.transform.position;
		player.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
	}

	public void LifeLost(int lifeToLoose) {
		lives -= lifeToLoose;
	}

	     


	// Update is called once per frame
	void Update () {



		if (lives <= 0) {
			player.GetComponent<PlayerHealth>().Death();
		}
	}




}
