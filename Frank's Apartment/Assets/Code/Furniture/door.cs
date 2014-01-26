using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
    bool clicked = false;
    bool locked = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    void OnMouseDown()
    {
        //clicked?
        if (clicked == false)
        {
            clicked = true;
        }
        else if (clicked == true)
        {
            clicked = false;
        }

        //lock the door
        if (clicked == false)
        {
            locked = false;
        }
        else if (clicked == true)
        {
            locked = true;
        }

        //if locked character cannot open door
        if (locked == false)
        {
            collider.enabled = false;
        }
        else if (locked == true)
        {
            collider.enabled = true;
        }
    }

    //move the 
    void OnMouseDrag()
    {
        transform.position = Vector3();
    }
}
