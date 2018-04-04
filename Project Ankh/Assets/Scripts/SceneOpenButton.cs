using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOpenButton : MonoBehaviour {

	public string sceneToLoad;

	public void NextScene()
	{
		SceneManager.LoadScene (sceneToLoad);
	}
}