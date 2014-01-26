using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI ()
	{
		if (GUI.Button (new Rect( Screen.width / 1.3f, Screen.height - (Screen.height / 5f), 100, 50), "Play"))
			Application.LoadLevel(1);
		
		GUI.Label (new Rect( Screen.width / 5f, Screen.height - (Screen.height / 5f), 250, 50), "Contributors: Matt Chen, Roman Sharf, Johnny Mkitarian, Seori Sachs");
		
	}
}
