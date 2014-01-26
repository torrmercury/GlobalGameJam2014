using UnityEngine;
using System.Collections;

public class toilet : MonoBehaviour {
    bool clicked;
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
        //play the water spout
        //was it clicked?
        if (clicked == false)
        {
            clicked = true;
            audio.Play();
            TenantAI.scareCount += 1;
            collider.isTrigger = true;
        }
        else if (clicked == true)
        {
            clicked = false;
            collider.isTrigger = false;
        }

        //for movement/drag
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

    //move the drag
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}
