using UnityEngine;
using System.Collections;

public class cameraBehavior : MonoBehaviour {

    Rect windowRect = new Rect(20, 20, 170, 80);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    void OnGUI()
    {
        windowRect = GUI.Window(0, windowRect, DoMyWindow, "Menu");
    }
    void DoMyWindow(int windowID)
    {
        if (GUI.Button(new Rect(10, 20, 150, 20), "Exit to Title Screen"))
        {
            Application.LoadLevel("Title");
        }
        if (GUI.Button(new Rect(10, 50, 150, 20), "Exit Game"))
        {
            Application.Quit();
        }
    }
}
