using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class PlayerHealth : MonoBehaviour {
	public int health = 1;
	public int lifeToLose = 1;
	private NavMeshAgent mNavMeshAgent;
	public GameObject gameController;
	public GameObject gameOverMenu;
	public bool playerIsAlive = true;


	public void TakeDamage(int damageToTake) {
		health -= damageToTake;
	}


	void Start () {
		gameOverMenu.SetActive(false);
	}


	public void Death(){
		GetComponent<NavMeshAgent>().isStopped = true;
		gameOverMenu.SetActive(true);

	}  


	void Die(){
		//GetComponent<NavMeshAgent>().enabled = false;
		gameController.GetComponent<CheckPointSystem>().LifeLost(lifeToLose);
		gameController.GetComponent<CheckPointSystem>().RespawnPlayer();
		health = 1;
	}



	public void Update () {
		
		if (health <= 0) {
			if (playerIsAlive) {
				playerIsAlive = false;
				Invoke ("Die", 0.5f);
			}
		}
	}
}