using UnityEngine;
using System.Collections;

public class CharacterRoomLocation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//get the collider component
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider other)
	{
		print ("Colliding!");
	}
}
