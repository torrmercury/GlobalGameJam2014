using UnityEngine;
using System.Collections;

public class couch : MonoBehaviour {
    bool clicked;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        
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

        //spring pops out
        if (clicked == false)
        {
            renderer.enabled = false;
            collider.isTrigger = false;
        }
        else if (clicked == true)
        {
            TenantAI.scareCount += 1;
            renderer.enabled = true;
            collider.isTrigger = true;
            
            //needs a section on making the character go flying when the spring comes up
            //most likely use "public static Vector3 position" in the TenantAI code
            //which translates here as TenantAI.position
        }
    }

    //move the 
    void OnMouseDrag()
    {
        transform.position = Vector3();
    }
}
