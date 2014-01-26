using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public GameObject firstTenant;

	// Use this for initialization
	void Start () {
		Instantiate(firstTenant, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
