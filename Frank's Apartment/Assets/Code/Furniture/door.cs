using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
    bool clicked = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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

        }
        else if (clicked == true)
        {

        }
    }
}
