using UnityEngine;
using System.Collections;

public class couch : MonoBehaviour {
    Vector3 screenPoint;
    Vector3 offset;
    float lockedYPos = .6f;
    public static bool couchClicked = false;

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
        if (couchClicked == false)
        {
            couchClicked = true;
            collider.isTrigger = true;
            
        }
        else if (couchClicked == true)
        {
            
            TenantAI.scareCount += 1;
            //collider.isTrigger = false;
            

            //needs a section on making the character go flying when the spring comes up
            //most likely use "public static Vector3 position" in the TenantAI code
            //which translates here as TenantAI.position
        }

        //for movement/drag
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 4f * Input.mousePosition.y, screenPoint.z));

    }

    //move the couch
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, 4f * Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.y = lockedYPos;
        transform.position = curPosition;
    }

}
