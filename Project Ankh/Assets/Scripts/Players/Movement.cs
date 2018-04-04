using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
	public LayerMask navLayer;
	private Animator mAnimator;
	private NavMeshAgent mNavMeshAgent;
	private bool mRunning = false;
	public int sprintButtonPressed = 0;

	// Use this for initialization
	void Start ()
	{
		mAnimator = GetComponent<Animator> ();
		mNavMeshAgent = GetComponent<NavMeshAgent> ();
		navLayer = (1 << LayerMask.NameToLayer("Default")); 
	}
	
	// Update is called once per frame
	void Update ()
	{
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hit;

		if (Input.GetMouseButtonDown (0) && GetComponent<PlayerHealth> ().health > 0f) {
			if (Physics.Raycast (ray, out hit, 100, navLayer)){		
				if (hit.collider.gameObject.tag == "NavSurface")
				mNavMeshAgent.destination = hit.point;
				//Debug.Log(hit.collider.gameObject.tag);
			}
				
		}
	
		if (mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance) {
			mRunning = false;
		} else {
			mRunning = true;
		}
		mAnimator.SetBool ("running", mRunning);



		// check if sprint key is pressed
		if (Input.GetKeyDown(KeyCode.LeftShift)){
			sprintButtonPressed++;
		}
		if (Input.GetKeyUp(KeyCode.LeftShift)){
			sprintButtonPressed--;
		}

		// set movement speed, depending id player is pressing sprint key or button (or not)
		UpdateSprintState ();




	}



	public void SprintButtonPressed(){
		// check if sprint button is pressed
		sprintButtonPressed++;
	}


	public void SprintButtonReleased(){
		// check if sprint button is released
		sprintButtonPressed--;
	}



	void UpdateSprintState(){
		if (sprintButtonPressed > 0) {
			GetComponent<NavMeshAgent> ().speed = (5.0f);
		} else {
			GetComponent<NavMeshAgent> ().speed = (5.0f);
		}
	}



}