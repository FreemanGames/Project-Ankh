using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTrap : MonoBehaviour {
	public float projectileSpeed = 20;
	public GameObject projectilePrefab;
	public GameObject launcher;
	public bool shot = true;
	public float timeBetweenShots;
	private float timer;
	public Transform projectileSpawnPoint;

	// Use this for initialization
	void Start () {
		timer = Time.time;
		Shoot ();
	}

	private void Shoot (){
		GameObject GO = Instantiate (projectilePrefab,
			projectileSpawnPoint.position, Quaternion.identity) as GameObject;
		GO.GetComponent<Rigidbody> ().AddForce
		(launcher.transform.forward * projectileSpeed, ForceMode.Impulse);
		shot = false;
		Invoke ("ShotDelay", 3);
	}

	private void ShotDelay(){
		shot = true;
		Shoot ();

	}

	// Update is called once per frame
	void Update () {
		
	}
}
