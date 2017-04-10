using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	//public GameObject _brick; 
	// var def 
	public AudioClip _audio;



	public GameObject _gamer;

	// detect collision
	//GameObject.tag = "block";


	void OnCollisionEnter2D(Collision2D target){
		

		if (target.gameObject.tag == "BottomWall") {
			//AudioSource.PlayClipAtPoint (_audio, transform.position);
			//Debug.Log ("block collected");
			Destroy (gameObject);
			//_gamer.Addbucket ();
		}
	}

		/*

	    if (target.gameObject.tag == "Block") {
			Debug.Log ("BLOC block");
			//_gamer.Addbucket();
			Destroy (gameObject);

		}
*/

		//Invoke ("Die1", 0.1f);


	// Use this for initialization
	void Start () {
	}



	/*
	void Die1(){
		Destroy (gameObject);

		_gamer.Addbucket();

	}*/
	
	// Update is called once per frame
	void Update () {
	
	}
}
