using UnityEngine;
using System.Collections;

public class HideRoom : MonoBehaviour {
	
	Renderer[] roomElements;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void HideTheRoom () 
	{
		roomElements = transform.GetComponentsInChildren<Renderer>();
		//print ("Renderers: " + ChildrenRenderer[0]);
		foreach (Renderer rend in roomElements)
		{
			rend.enabled = false;
		}
	}
}
