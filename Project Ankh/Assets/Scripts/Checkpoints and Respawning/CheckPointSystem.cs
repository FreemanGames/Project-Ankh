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


	public void LifeLost(int lifeToLoose) {
		lives -= lifeToLoose;
	}

	// Update is called once per frame
	void Update () {
		if (lives <= 0) {
			Debug.Log ("something");
		}
	}
}
