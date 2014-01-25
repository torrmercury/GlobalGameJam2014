using UnityEngine;
using System.Collections;

public class TenentAI : MonoBehaviour {

	int Health = 5;
	int[] Goals = new int[hunger, sleep, sex, excretion];
	string Objective;
	
	bool dead = 0;
	public int deadBodies;
	int bodies;
	
	// Use this for initialization
	void Start () {
		//array of goals
		//hunger, sleep, sex, excretion
		//choose path


		bodies = deadBodies;
		ChooseGoal();
	}
	
	// Update is called once per frame
	void Update () {
		//start walking path
		//choose new path if interrupted
			//Interruption


		if (dead = 1) {
			bodies += 1;
			deadBodies = bodies;
			Instantiate (body);
			Destroy (this);
		}
	}
}


void ChooseGoal () {
	int Goal = Random.Range (0, 100);
	if (0 <= Goal <= 24) {
		Objective = 'hunger';
		else if (25 <= 