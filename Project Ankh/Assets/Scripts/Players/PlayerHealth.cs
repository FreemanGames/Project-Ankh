using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
	public int health = 1;
	public int lifeToLose = 1;

	public void TakeDamage(int damageToTake) {
		health -= damageToTake;
	}


	void Start () {

	}


	public void Update () {
		if (health <= 0) {
			GetComponent<CheckPointSystem>
			().LifeLost (lifeToLose);
			Destroy (this.gameObject);
		}
	}
}