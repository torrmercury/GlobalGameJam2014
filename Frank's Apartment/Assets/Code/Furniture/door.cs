using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
    bool clicked = false;
    bool locked = false;
    Vector3 screenPoint;
    Vector3 offset;
    float lockedYPos;
    float lockedZPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        /*lockedYPos = transform.position.y;
        lockedZPos = transform.position.z;*/
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
        /*
        //for movement/drag
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 4f * Input.mousePosition.y, screenPoint.z));
        */
    }

    //move the couch
    /*void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, 4f * Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.y = lockedYPos;
        curPosition.z = lockedZPos;
        transform.position = curPosition;
    }
    */
}
