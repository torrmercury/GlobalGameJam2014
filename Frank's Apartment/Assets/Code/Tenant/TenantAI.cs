using UnityEngine;
using System.Collections;
using Vectrosity; // C#

public class TenantAI : MonoBehaviour {
    public body spawnBody;
    public static int scareCount = 0;

	int Health = 5;
	string[] Goals = new string[] {"Hunger", "Sleep", "Sex", "Excretion"};
	string Objective;
	GameObject Destination;

	VectorLine myLine;
	Vector3 LineOrigin;
	Vector3 LineFinish;
	public Material lineMaterial;

	public int deadBodies;
	int bodies;
	
	// Use this for initialization
	void Start () {
        //dead body count
        bodies = deadBodies;


		//array of goals
		//hunger, sleep, sex, excretion
		//choose path
		//Run function to choose Objective
		ChooseGoal();
	}
	
	// Update is called once per frame
	void Update () {
		//start walking path
		//choose new path if interrupted
		RefreshLine();
		//Choose new Objective test
		if (Input.GetKeyDown("space")) {
		    ChooseGoal();
		}

	}

    //when the character enters/touches a trigger, it dies
    void OnTriggerEnter ()
    {
        body deadBody;
        bodies += 1;
        deadBodies = bodies;
        deadBody = Instantiate (spawnBody, transform.position, Quaternion.identity) as body;
        Destroy(this);
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

		print(Objective);
		ChooseObjective();

	}
	//function to choose the AI's intended path based on their goal and what is closest.
	void ChooseObjective () {
		//make an array with all the objects that will satisfy the goal.
		GameObject[] Choices = GameObject.FindGameObjectsWithTag(Objective);
		print (Choices.Length);
		//set Destination as the first index in the array as a starting point for use in the coming loop.
		Destination = Choices[0];
		//loop to find the closest goal-satisfying-object and set it as the Destination.
		//for loop to cycle through all the choices with n.
		for (int n = 0; n < Choices.Length; n++) {
			//set the distance between AI/choices[n] and Destination/AI to compare in if statement. 
			float Distance1 = Vector3.Distance(Choices[n].transform.position, transform.position);
			print ("Distance 1 is " + Distance1);
			float Distance2 = Vector3.Distance(Destination.transform.position, transform.position);
			print ("Distance 2 is " + Distance2);
			//Compare the distances, set the shorter distance as Destination.
			if (Distance1 < Distance2) {
				Destination = Choices[n];
			}
		}
		print (Destination);
		//draw line to destination
		myLine = VectorLine.SetLine3D(Color.green, LineOrigin, LineFinish);

		
	}

	void SetLinePoints () {
		//Set the Line Points
		LineOrigin = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		LineFinish = new Vector3(Destination.transform.position.x, Destination.transform.position.y, Destination.transform.position.z);
	}

	void RefreshLine() {
		//Resets line points and then draws line.
		//VectorLine.Destroy (myLine);
		SetLinePoints();
		myLine.Draw();
	}

}
