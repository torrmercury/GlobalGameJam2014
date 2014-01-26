using UnityEngine;
using System.Collections;
using Vectrosity; // C#

public class TenantAI : MonoBehaviour {
    public GameObject deadBody;
	public GameObject spawnPoint;
	public GameObject newTenant;
	public GameObject hungerBubble;
	public GameObject sexBubble;
	public GameObject excretionBubble;
	public GameObject sleepBubble;


    public static int scareCount = 0;
	public int deadBodies;
	int bodies;
    public static bool newGoal = false;

//	string[] Goals = new string[] {"Hunger", "Sleep", "Sex", "Excretion"};
	string Objective;
	GameObject Destination;


//	Vector3 LineOrigin;
//	Vector3 LineFinish;
//	//Vector3[] linePoints;
//	VectorLine myLine;
//	public Material lineMaterial;
	float currentPos;
	float destinyPos;
	float currentZ;
	float destinyZ;
	
	void Start () {
		spawnPoint = GameObject.FindWithTag("Respawn");
        //dead body count
        bodies = deadBodies;

		//Run function to choose Objective
		ChooseGoal();

	}


	void Update () {
		//set current pos, check vs destination pos to see what direction AI moving, set localScale accordingly.
		currentPos = transform.position.x;
		currentZ = transform.position.z;
//		print ("destination coordinates are " + Destination.transform.position);
		Vector3 destinationPos = Destination.transform.position;
		destinyPos = destinationPos.x;
		destinyZ = destinationPos.z;
//		destinyPos = Destination.transform.position.x;
		if (currentPos - destinyPos > 0) {
			Vector3 tempScale = transform.localScale;
			tempScale.x = 0.5f;
			transform.localScale = tempScale;
		}

		if (currentPos - destinyPos < 0) {
			Vector3 tempScale = transform.localScale;
			tempScale.x = -0.5f;
			transform.localScale = tempScale;
		}

		if (Mathf.Abs(currentPos - destinyPos) < .25 && Mathf.Abs(currentZ - destinyZ) < .25) {

			Destroy(GameObject.FindGameObjectWithTag("Bubble"));
			Destroy(GameObject.FindGameObjectWithTag("Bubble"));
			ChooseGoal();
		}

		//start walking path
		//choose new path if interrupted
//		RefreshLine();
//		transform.localscale.x = -x;
		//Choose new Objective test
		if (Input.GetKeyDown("space")) {
			Destroy(GameObject.FindGameObjectWithTag("Bubble"));
			Destroy(GameObject.FindGameObjectWithTag("Bubble"));

		    ChooseGoal();
            newGoal = true;
            newGoal = false;
		}

		StartCoroutine(HoldUp());



		if (Input.GetKeyDown("k")) {
			Death ();
		}
//		MoveOne();
//		if (transform.position.x >= Destination.transform.position.x) {
//			MoveTwo();
//	}

	}

	IEnumerator HoldUp() {
		yield return new WaitForSeconds(2f);
		Vector3 firstMove = new Vector3(destinyPos, 1, currentZ);
		Vector3 secondMove = new Vector3(currentPos, 1, destinyZ);
		transform.position = Vector3.Lerp(transform.position, firstMove, Time.deltaTime);
		transform.position = Vector3.Lerp(transform.position, secondMove, Time.deltaTime);
	}

void Death () {
		Destroy(this.transform.gameObject);
		Instantiate (deadBody, transform.position, Quaternion.Euler(270,270,0));
//		StartCoroutine("NewTenant");
		Instantiate (newTenant, spawnPoint.transform.position, Quaternion.identity);
	}
    //when the character enters/touches a trigger, it dies
    void OnTriggerEnter (Collider other)
    {
		if (other.gameObject.tag == "Floor") {
			print ("OMG I RUN THROUGH WALLS");
		}
		else if (other.gameObject.tag == "Corpse") {
			print ("EWWWWWWW!");
		}
		else {
			Death ();
		}
//        body deadBody;
//        bodies += 1;
        //deadBodies = bodies;
//        deadBody = Instantiate (spawnBody, transform.position, Quaternion.identity) as body;
    }

	//function to choose an Objective
	void ChooseGoal () {
		//roll from 1 to 4 to make choice
		int Goal = Random.Range (1, 5);
		GameObject bubble;
		if (Goal == 1) {
			Objective = "Hunger";
			bubble = hungerBubble;
			bubble = Instantiate(hungerBubble, transform.position, Quaternion.identity) as GameObject;
			bubble.transform.parent = this.transform;
			bubble.transform.localPosition = new Vector3 (0f,5f,0f);
		}
			else if (Goal == 2) {
			Objective = "Sleep";
			bubble = sleepBubble;
			bubble = Instantiate(bubble, transform.position, Quaternion.identity) as GameObject;
			bubble.transform.parent = this.transform;
			bubble.transform.localPosition = new Vector3 (0f,5f,0f);
		}
			else if (Goal == 3) {
			Objective = "Sex";
			bubble = sexBubble;
			bubble = Instantiate(bubble, transform.position, Quaternion.identity) as GameObject;
			bubble.transform.parent = this.transform;
			bubble.transform.localPosition = new Vector3 (0f,5f,0f);
		}
			else if (Goal == 4) {
			Objective = "Excretion";
			bubble = excretionBubble;
			bubble = Instantiate(bubble, transform.position, Quaternion.identity) as GameObject;
			bubble.transform.parent = this.transform;
			bubble.transform.localPosition = new Vector3 (0f,5f,0f);
		}


		//Destroy(bubble.transform.gameObject);

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
			//print ("Distance 1 is " + Distance1);
			float Distance2 = Vector3.Distance(Destination.transform.position, transform.position);
			//print ("Distance 2 is " + Distance2);
			//Compare the distances, set the shorter distance as Destination.
			if (Distance1 < Distance2) {
				Destination = Choices[n];
			}
		}
		print (Destination);
		//draw line to destination
//		myLine = VectorLine.SetLine3D(Color.red, LineOrigin, LineFinish);

	}

//	void SetLinePoints () {
//		//Set the Line Points
//		LineOrigin = new Vector3(transform.position.x, transform.position.y, transform.position.z);
//		LineFinish = new Vector3(Destination.transform.position.x, Destination.transform.position.y, Destination.transform.position.z);
//	}

//	void RefreshLine() {
//		//Resets line points and then draws line.
//		//VectorLine.Destroy (myLine);
//		SetLinePoints();
//		myLine.Draw();
//	}

//	void MoveOne() {
//		Vector3 firstMove = new Vector3(Destination.transform.position.x, 1, transform.position.z);
//		Vector3 secondMove = new Vector3(transform.position.x, 1, Destination.transform.position.z);
//		transform.position = Vector3.Lerp(transform.position, firstMove, Time.deltaTime);
//
//	}
//
//	void MoveTwo() {
//		Vector3 firstMove = new Vector3(Destination.transform.position.x, 1, transform.position.z);
//		Vector3 secondMove = new Vector3(transform.position.x, 1, Destination.transform.position.z);
//		transform.position = Vector3.Lerp(transform.position, secondMove, Time.deltaTime);
//	}
}
