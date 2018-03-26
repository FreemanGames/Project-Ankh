﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class PlayerHealth : MonoBehaviour {
	public int health = 1;
	public int lifeToLose = 1;
	private NavMeshAgent mNavMeshAgent;
	public GameObject gameController;

	public void TakeDamage(int damageToTake) {
		health -= damageToTake;
	}


	void Start () {

	}


	public void Death(){
		GetComponent<NavMeshAgent>().enabled = false;

	}  

	public void Update () {
		
		if (health <= 0) {
			gameController.GetComponent<CheckPointSystem>().LifeLost(lifeToLose);
			gameController.GetComponent<CheckPointSystem>().RespawnPlayer();
			health = 1;
		}
	}
}