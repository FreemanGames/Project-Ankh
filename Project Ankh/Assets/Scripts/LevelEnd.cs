using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour {
	// level to load
	public string loadLevel;



void OnTriggerEnter(Collider other){
		// if other colliders tag is player
	if (other.tag == "Player") {
			// open scene
			SceneManager.LoadScene (loadLevel, LoadSceneMode.Single);
	}
	}
}