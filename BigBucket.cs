using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBucket : MonoBehaviour {
	public Gamer _gamer;
	public int _bucketcount ; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D target){
		//Debug.Log ("deadly wall collision detected");

		if (target.gameObject.tag == "Bucket") {

			_bucketcount = _gamer._bucket;
			//Debug.Log ("current bucket is " + _bucketcount.ToString ());
			_gamer.Addtotal (_bucketcount);
			_gamer.Resetbucket ();
		}

		if (target.gameObject.tag == "Block") {
			_gamer.Addbucket ();
			Destroy (target.gameObject);
		}

	}
}
