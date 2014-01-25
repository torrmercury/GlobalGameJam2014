﻿using UnityEngine;
using System.Collections;

public class TenantAI : MonoBehaviour {


	int Health = 5;
	string[] Goals = new string[] {"Hunger", "Sleep", "Sex", "Excretion"};
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
		if (Input.GetKeyDown("space")) {
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
		int Goal = Random.Range (1, 5);

		if (Goal == 1) {
			Objective = "Hunger";
		}
			else if (Goal == 2) {
			Objective = "Sleep";
		}
			else if (Goal == 3) {
			Objective = "Sex";
		}
			else if (Goal == 4) {
			Objective = "Excretion";
		}

		//figure out how to print to test objective selection
		//Debug.Log (Objective);
		Debug.Log(Objective);
		ChooseObjective();

	}
	//function to choose the AI's intended path based on their goal and what is closest.
	void ChooseObjective () {
		//make an array with all the objects that will satisfy the goal.
		GameObject[] Choices = GameObject.FindGameObjectsWithTag(Objective);
		print (Choices.Length);
		print (transform.position);
		//loop to eliminate all but closest goal-satisfying-objective from the array.
//		while (Choices[1]) {
//			int Distance1 = Vector3.Distance(transform.position, Choices[0].position);
//			int Distance2 = Vector3.Distance(transform.position, Choices[1].position);
//			if (Distance1 < Distance2) {
//				Array.RemoveAt(1);
//			}
//				else {
//					Array.RemoveAt(0);
//				}
//		}
	}

}
