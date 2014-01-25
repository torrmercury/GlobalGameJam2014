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

    void OnMouseDown()
    {
        if (clicked == false)
        {
            clicked = true;
        }
        else if (clicked == true)
        {
            clicked = false;
        }

        if (clicked == false)
        {
            locked = false;
        }
        else if (clicked == true)
        {
            locked = true;
        }
    }
}
