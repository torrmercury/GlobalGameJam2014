﻿using UnityEngine;
using System.Collections;

public class portrait : MonoBehaviour {
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

        //it now talks!!!! WHOOOAAAAAAA I'M FRAAAANK
        if (clicked == false)
        {
            //what to do?
        }
        else if (clicked == true)
        {
            audio.Play();
            TenantAI.scareCount += 1;
        }
    }

    //move the 
    void OnMouseDrag()
    {
        transform.position = Vector3();
    }
}
