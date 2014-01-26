using UnityEngine;
using System.Collections;

public class fridge : MonoBehaviour {
    bool clicked = false;
    Vector3 screenPoint;
    Vector3 offset;

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
        /*
        //for movement/drag
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
         */
	}

    /*
    //move the fridge
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }*/
}