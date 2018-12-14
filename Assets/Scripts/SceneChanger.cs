using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	public void ChangeSceneTo(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
