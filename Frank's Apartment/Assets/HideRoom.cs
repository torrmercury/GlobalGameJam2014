using UnityEngine;
using System.Collections;

public class HideRoom : MonoBehaviour {
	
	Renderer[] roomElements;
	
	// Use this for initialization
	void Start () {
		HideTheRoom ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerExit (Collider other) {
		if (other.gameObject.tag == "Tenant") {
			HideTheRoom ();
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Tenant") {
			ShowTheRoom ();
		}

		if (other.gameObject.tag == "Corpse") {
			HideTheRoom ();
		}
	}

	void HideTheRoom () 
	{
		roomElements = transform.parent.GetComponentsInChildren<Renderer>();
		//print ("Renderers: " + ChildrenRenderer[0]);
		foreach (Renderer rend in roomElements)
		{
			if (rend.gameObject.tag != "Door") 
				rend.enabled = false;
		}
	
	}

	void ShowTheRoom () 
	{
		roomElements = transform.parent.GetComponentsInChildren<Renderer>();
		//print ("Renderers: " + ChildrenRenderer[0]);
		foreach (Renderer rend in roomElements)
		{
			rend.enabled = true;
		}
		
	}
}
