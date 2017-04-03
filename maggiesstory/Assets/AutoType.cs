// base script receieved from http://wiki.unity3d.com/index.php?title=AutoType

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoType : MonoBehaviour {

	public float letterPause = 0.2f;
	public AudioClip sound;
	private Text txt {
		get {
			return GetComponent<Text> ();
		}
	}


	string message;

	// Use this for initialization
	void Start () {
		message = txt.text;
		txt.text = "";
		StartCoroutine(TypeText ());
	}

	IEnumerator TypeText () {
		foreach (char letter in message.ToCharArray()) {
			txt.text += letter;
			yield return 0;
			yield return new WaitForSeconds (letterPause);
		}      
	}
}
