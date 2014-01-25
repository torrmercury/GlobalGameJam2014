using UnityEngine;
using System.Collections;

public class TenentAI : MonoBehaviour {
<<<<<<< HEAD

	int Health = 5;
	string[] Goals = new string[] {"hunger", "sleep", "sex", "excretion"};
	string Objective;

=======
>>>>>>> master
	bool dead = false;
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

<<<<<<< HEAD
		if (Input.GetKeyDown("k")) {
		    ChooseGoal();
		}

		/*if (dead = 1) {
=======
		if (dead == true)
		{
>>>>>>> master
			bodies += 1;
			deadBodies = bodies;
			//Instantiate (body);
			Destroy (this);
		}*/
	}

	void ChooseGoal () {
		int Goal = Random.Range (0, 100);

		if (0 <= Goal <= 24) {
			Objective = "hunger";
		}
			else if (25 <= Goal <= 49) {
			Objective = "sleep";
		}
			else if (50 <= Goal <= 74) {
			Objective = "sex";
		}
			else if (75 <= Goal <= 100) {
			Objective = "excretion";
		}

		console.log (Objective);
	}
}
