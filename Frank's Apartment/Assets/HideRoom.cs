using UnityEngine;
using System.Collections;

public class HideRoom : MonoBehaviour {
	
	Renderer[] ChildrenRenderer;
	
	// Use this for initialization
	void Start () {
		ChildrenRenderer = transform.GetComponentsInChildren<Renderer>();
		print ("Renderers: " + ChildrenRenderer[0]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
