using UnityEngine;
using System.Collections;

public class TenentAI : MonoBehaviour {
	bool dead = 0;
	public int deadBodies;
	int bodies;
	// Use this for initialization
	void Start ()
	{
		bodies = deadBodies;
	}
	
	// Update is called once per frame
	void Update () {

		if (dead = 1)
		{
			bodies += 1;
			deadBodies = bodies;
			Instantiate (body);
			Destroy (this);
		}
	}
}
