// base script receieved from http://wiki.unity3d.com/index.php?title=AutoType

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AutoTypeRunner : MonoBehaviour {

	public float letterPause = 0.025f;
	public AudioClip sound;
	private AudioSource source {
		get {
			return GetComponent<AudioSource> ();
		}
	}
	private Text txt {
		get {
			return GetComponent<Text> ();
		}
	}
	public GameObject currentLine;
	public string nextSceneName;
	private GameObject nextLine;
	string message;
	private int value;
	private char[] chars;
	private bool stopped = false;

	// Use this for initialization
	void Start () {
		message = txt.text;
		txt.text = "";
		IEnumerator typeText;
		typeText = TypeText (letterPause);
		StartCoroutine(typeText);
	}

	IEnumerator TypeText (float letterPause) {
		stopped = false;
		foreach (char letter in message.ToCharArray()) {
			txt.text += letter;
			yield return 0;
			//AudioSource.PlayClipAtPoint (sound, transform.position);
			yield return new WaitForSeconds (letterPause);
			if (stopped) {
				txt.text = "";
				txt.text = message;
				yield break;
			}
		}
		Debug.Log (gameObject.GetComponent<Text>().text);
	}

	void Update() {
		if (Input.GetKeyDown ("space")) {
			stopped = true;
			var num = getNum ();
			var newNum = num + 1;
			if ((nextLine = GameObject.Find ("line" + newNum)) == null) {
				//Debug.Log ("go to next scene");
				SceneManager.LoadScene (nextSceneName);
			} else {
				//Debug.Log("line" + newNum);
				//Debug.Log (GameObject.Find("line" + newNum));
				prepareForNextLine(newNum);

			}
		}
	}


	void prepareForNextLine(int newNum) {
		nextLine.GetComponent<Text> ().enabled = true;
		nextLine.GetComponent<AutoTypeRunner> ().enabled = true;
		currentLine = GameObject.Find ("line" + newNum);
	}

	int getNum() {
		chars = currentLine.name.ToCharArray();
		//Debug.Log ("array of chars: " + chars);
		foreach (char s in chars) {
			//Debug.Log("current char: " + s);
			if (char.IsNumber(s)) {
				//Debug.Log ("is char a num?: " + char.IsNumber(s));
				value = (int)char.GetNumericValue (s);
				//Debug.Log ("int version: " + value);
				return value;
			}
		}
		Debug.Log ("something's wrong...");
		return -1;
	}

}
