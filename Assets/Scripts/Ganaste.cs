using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ganaste : MonoBehaviour {
	
	public SceneChanger sceneChanger;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider Ganaste)
	{
		if(Ganaste.tag == "Player")
		{
			sceneChanger.ChangeSceneTo("GanasteScene");
		}
	}
}
