using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {
	public float score;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		UpdateText ();
	}

	public void AddScore(float scoreToAdd)
	{
		score += scoreToAdd;
		UpdateText ();
	}

	public float GetScore () {
		return score;
	}
	private void UpdateText(){
		scoreText.text = "Score: " + score.ToString();
	}
	

}
