using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public LayerMask raycastLayerMask; 
	public GameObject movementMarker;
	public GameObject player;

	void Update (){
		RaycastHit hit;
		Ray ray =
			Camera.main.ScreenPointToRay (Input.mousePosition);
		float distanceOfRay = 100;
		if (Physics.Raycast (ray, out hit, distanceOfRay, raycastLayerMask)) {

			if (Input.GetMouseButton (0)) {
				if (hit.transform.tag == "Ground") {
					movementMarker.transform.position = hit.point;

					player.GetComponent<PlayerController> ().MovePlayer (hit.point);
				}
			}
		}

	}
}