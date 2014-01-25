using UnityEngine;
using System.Collections;

public class RoomChooser : MonoBehaviour {
	int x;
	public int deadBodies;

	// Use this for initialization
	void Start ()
	{
		if (deadBodies < 5)
		{
			x = deadBodies;
		}
		if (x == 0)
		{
			Instantiate (bathroom);

		}
		else if (x == 1)
		{
			Instantiate (bedroom);
			
		}
		else if (x == 2)
		{
			Instantiate (kitchen);
			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
