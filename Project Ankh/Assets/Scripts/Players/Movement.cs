using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

	private Animator mAnimator;
	private NavMeshAgent mNavMeshAgent;
	private bool mRunning = false;

	// Use this for initialization
	void Start () {
		mAnimator = GetComponent<Animator> ();
		mNavMeshAgent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hit;

		if (Input.GetMouseButtonDown (0) && GetComponent<PlayerHealth>().health > 0f) {
			if (Physics.Raycast (ray, out hit, 100))
				//;
			{
				mNavMeshAgent.destination = hit.point;
			}
				
		}
	
		if(mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance)
		{
		mRunning = false;
		}
		else
		{
		mRunning = true;
		}
	mAnimator.SetBool("running", mRunning);


		if (Input.GetKey (KeyCode.LeftShift)) {
			GetComponent<NavMeshAgent> ().speed = (5.0f);

		}
		else {
			GetComponent<NavMeshAgent> ().speed = (3.5f);
	
			}

	}
}