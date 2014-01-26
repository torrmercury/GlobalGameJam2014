using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour {
    public GUIStyle style; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy(gameObject, 10);
	}

    

	void OnGUI() {
		GUI.Label(new Rect (100, 100, 300, 100), "You are the apartment.\n You have the power.\n All tenants must die.", style);
	}
	

}
