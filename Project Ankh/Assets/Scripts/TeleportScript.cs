using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour {

	public GameObject teleportNode;

	//when someone enters the trigger
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			Vector3 nodeLocation = teleportNode.transform.position;
			Quaternion nodeRotation = teleportNode.transform.rotation;
			other.transform.position = nodeLocation;
			other.transform.rotation = nodeRotation;
		}
	}

}
