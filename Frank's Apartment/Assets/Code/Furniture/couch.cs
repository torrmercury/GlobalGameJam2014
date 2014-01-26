using UnityEngine;
using System.Collections;

public class couch : MonoBehaviour {
    bool clicked;
    Vector3 screenPoint;
    Vector3 offset;

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

        //for movement/drag
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    //move the couch
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}
