using UnityEngine;
using System.Collections;

public class fridge : MonoBehaviour {
    bool clicked = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		//was it clicked?
        if (clicked == false)
        {
            clicked = true;
        }
        else if (clicked == true)
        {
            clicked = false;
        }

        //open/close the door
        //play with this to see if we should use Vector3.up/forward/etc...
        if (clicked == false)
        {
            transform.LookAt(Vector3.forward);
        }
        else if (clicked == true)
        {
            transform.LookAt(Vector3.left);
            TenantAI.scareCount += 1;
        }
	}
}
