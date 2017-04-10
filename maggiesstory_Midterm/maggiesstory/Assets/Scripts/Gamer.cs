using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class Gamer : MonoBehaviour {
	public string leftKey = "left";
	public string rightKey = "right";
	public string upKey = "up";
	public string downKey = "down";

	public string fireKey = "space";

	//public GameObject _ball;

	public GameObject _brick;

	public Bucket _Bucket;

	public GameObject _fakeBucket;

	public GameObject bigBucket;

	public int _total =0;

	public int _bucket = 0;

	public bool _readyToPlay = false;

	public int x;
	public int y;

	public float seconds;

	public Text _totalUI;
	public Text _bucketUI;
	public Text _finalUI;
	public Text _beginUI;

	// Use this for initialization
	void Start () {
		GameObject newBucket = Instantiate (_fakeBucket, _fakeBucket.transform.position, Quaternion.identity) as GameObject;


		//createObj();

		if (_readyToPlay) {


			_fakeBucket.SetActive(true);

		}

	//	StartCoroutine (Example ());
		/*
		for (int  j=3; j>y; j--){
			for (int i=-6; i<x+1;i+=3){
				if (i == 0 && j == 2) {
					GameObject sBrick = Instantiate (_sbrick, new Vector2 (i, j), Quaternion.identity) as GameObject;
					sBrick.GetComponent<SBlock> ()._player = this.gameObject.GetComponent<Player> ();
					//sBrick.GetComponent<SBlock> ()._ball = this.gameObject.GetComponent<Ball> ();
				} else {
					GameObject newBrick = Instantiate (_brick, new Vector2 (i, j), Quaternion.identity) as GameObject;
					newBrick.GetComponent<Block> ()._player = this.gameObject.GetComponent<Player> ();
				}

			}
		}	*/

	}
/*
	IEnumerator Example(){
		seconds = Random.Range (0.1f, 3);
		yield return new WaitForSeconds(seconds);

	}*/
	// Update is called once per frame
	void Update () {
		Debug.Log ("update");
		if (Input.GetKey (leftKey)) {
			transform.Translate (new Vector2 (-0.2f, 0));


		} else if (Input.GetKey (rightKey)) {
			transform.Translate (new Vector2 (0.2f, 0));

		} else if (Input.GetKey (downKey)) {
			Debug.Log ("Down");
			transform.Translate (new Vector2 (0,  -0.2f));


		}else if (Input.GetKey (upKey)) {
			Debug.Log ("up");
			transform.Translate (new Vector2 (0, 0.2f));
		}


		if (_readyToPlay && Input.GetKey (fireKey)) {
			Play();
			//_readyToPlay = false;


		}

	}


	void OnCollisionEnter2D(Collision2D target){


		if (target.gameObject.tag == "Block") {
			//AudioSource.PlayClipAtPoint (_audio, transform.position);
			Debug.Log ("block collected");
			Destroy (target.gameObject);
			Addbucket ();
		}



		/*
		if (target.gameObject.tag == "Block") {
			Debug.Log ("BLOC block");
			//_gamer.Addbucket();
			Destroy (gameObject);

		}*/
	}

	void Play(){
		//hide fakeBucket
		Debug.Log ("inplay");
		_fakeBucket.SetActive(true);

		//instantiate new bucket from prefab at the position of the fakeBucket
		Bucket newBucket = Instantiate (_Bucket, _fakeBucket.transform.position, Quaternion.identity) as Bucket;

		for (int i = 50; i > 0; i--) {
		//while (_total != 10){
			//Debug.Log(i);
				x = Random.Range (-7, 6);
				y = Random.Range (1, 50);
				//x = Mathf.Round(x);
				Debug.Log (x);

				GameObject newBrick = Instantiate (_brick, new Vector2 (x, y), Quaternion.identity) as GameObject;
			}


		_beginUI.text = " ";


		_readyToPlay=false;

	}

	/*void OnCollisionEnter2D(Collision2D target){
		_bucket += 1;
		Debug.Log (_bucket);
	}*/

	public void Addbucket(){

		if (_bucket < 5) {
			_bucket += 1;
			_bucketUI.text = "In bucket: " + _bucket.ToString ();
		}
	}

	public void Addtotal(int _count){
		_total =_total + _count;
		//Debug.Log ("Total is" + _total.ToString ());

		_totalUI.text = "Total Collected: " + _total.ToString ();
		//Debug.Log ("Totalafter is" + _total.ToString ());
		//GameObject newBucket = Instantiate (_fakeBucket, _fakeBucket.transform.position, Quaternion.identity) as GameObject;

	}

	public void Resetbucket(){
		_bucket = 0;
		_bucketUI.text = "In bucket: " + _bucket.ToString ();
		Debug.Log ("bucktcount" + _bucket.ToString ());
		//GameObject newBucket = Instantiate (_fakeBucket, _fakeBucket.transform.position, Quaternion.identity) as GameObject;
	}


	IEnumerator createObj(){
		Debug.Log ("time");
		print(Time.time);
		yield return new WaitForSeconds(5);
		print(Time.time);
	}
		/*x = Random.Range(-7, 7);
		//x = Mathf.Round(x);
		Debug.Log("x is");
		Debug.Log (x);
		GameObject newBrick = Instantiate (_brick, new Vector2(x , 5), Quaternion.identity) as GameObject;
		yield return new WaitForSeconds(5);


	}*/
}
