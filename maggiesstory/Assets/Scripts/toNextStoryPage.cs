using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toNextStoryPage: MonoBehaviour { 

	// Use this for initialization
	public void nextScene (int sceneNum) {
		//yield return new WaitForSeconds (1.0f); 

		Application.LoadLevel (sceneNum); 	
		Debug.Log ("page1");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
