using UnityEngine;
using System.Collections;

public class toilet : MonoBehaviour {
    bool clicked;

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

        //play the water spout
        //was it clicked?
        if (clicked == false)
        {
            
        }
        else if (clicked == true)
        {
            TenantAI.scareCount += 1;
        }
	}

    //move the 
    void OnMouseDrag()
    {
        transform.position = Vector3();
    }
}
