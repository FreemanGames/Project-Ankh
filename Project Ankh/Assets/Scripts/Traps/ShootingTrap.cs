using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTrap : MonoBehaviour {
	public float projectileSpeed = 20;
	public GameObject projectilePrefab;
	public GameObject launcher;
	public Transform projectileSpawnPoint;

	// Use this for initialization
	void Start () {
		Shoot ();
	}

	private void Shoot (){
		GameObject GO = Instantiate (projectilePrefab,
			projectileSpawnPoint.position, Quaternion.identity) as GameObject;
		GO.GetComponent<Rigidbody> ().AddForce
		(launcher.transform.forward * projectileSpeed, ForceMode.Impulse);
		Invoke ("ShotDelay", 3);
	}

	private void ShotDelay(){
		Shoot ();

	}

	// Update is called once per frame
	void Update () {
		
	}
}
