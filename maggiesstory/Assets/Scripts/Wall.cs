using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	//player will earn score
	//public Player _player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D target){
		//Debug.Log ("deadly wall collision detected");

		Destroy (target.gameObject);

		//_player.Lives();

	}
}
