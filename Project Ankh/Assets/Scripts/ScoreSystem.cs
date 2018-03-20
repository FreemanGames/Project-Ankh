using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour {
	public float score;


	// Use this for initialization
	void Start () {
		
	}

	public void AddScore(float scoreToAdd)
	{
		score += scoreToAdd;
	}

	public float GetScore()
	{
		return score;
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
