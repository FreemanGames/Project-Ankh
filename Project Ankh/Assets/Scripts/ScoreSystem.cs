using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour {
	public int score = 0;


	// Use this for initialization
	void Start () {
		
	}

	Public void AddScore(int points) {
		score = score + points;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
