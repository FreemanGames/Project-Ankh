using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBarrier : MonoBehaviour {

	public GameObject barrier;

	void OnTriggerEnter(){
		barrier.SetActive (true);
	}
}