using UnityEngine;
using System.Collections;

public class TenentAI : MonoBehaviour {


	int Health = 5;
	string[] Goals = new string[] {"hunger", "sleep", "sex", "excretion"};
	string Objective;


	bool dead = false;
	public int deadBodies;
	int bodies;
	
	// Use this for initialization
	void Start () {
		//array of goals
		//hunger, sleep, sex, excretion
		//choose path
		bodies = deadBodies;

		//Run function to choose Objective
		ChooseGoal();
	}
	
	// Update is called once per frame
	void Update () {
		//start walking path
		//choose new path if interrupted
			//Interruption

		//Choose new Objective test
		if (Input.GetKeyDown("k")) {
		    ChooseGoal();
		}

		/*if (dead = 1) {
		if (dead == true)
		{
			bodies += 1;
			deadBodies = bodies;
			//Instantiate (body);
			Destroy (this);
		}*/
	}

	//function to choose an Objective
	void ChooseGoal () {
		//roll from 1 to 4 to make choice
		int Goal = Random.Range (1, 4);

		if (Goal == 1) {
			Objective = "hunger";
		}
			else if (Goal == 2) {
			Objective = "sleep";
		}
			else if (Goal == 3) {
			Objective = "sex";
		}
			else if (Goal == 4) {
			Objective = "excretion";
		}

		//figure out how to print to test objective selection
		//Debug.Log (Objective);
	}
}
