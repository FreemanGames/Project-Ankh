using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointSystem : MonoBehaviour {

	public int lives = 3; 
	public GameObject player;
	public Transform spawnPoint;
	public Transform checkPoint;
	public Text livesText;

	// Use this for initialization
	void Start () {
		UpdateText ();
	}

	public void RespawnPlayer()
	{
		player.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
		player.transform.position = checkPoint.transform.position;
		player.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
	}

	public void LifeLost(int lifeToLoose) {
		lives -= lifeToLoose;
		UpdateText ();
	}

	private void UpdateText(){
		livesText.text = "Lives:" + lives.ToString ();
	}


	// Update is called once per frame
	void Update () {



		if (lives <= 0) {
			player.GetComponent<PlayerHealth>().Death();
		}
	}




}
