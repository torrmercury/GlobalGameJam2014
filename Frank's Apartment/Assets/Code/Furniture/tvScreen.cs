using UnityEngine;
using System.Collections;

public class tvScreen : MonoBehaviour
{
    Vector3 screenPoint;
    Vector3 offset;
    bool clicked = false;
    float lockedYPos = 1.2f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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

        //turn the screen on/off
        if (clicked == true)
        {
            renderer.enabled = true;
            TenantAI.scareCount += 1;
        }
        else if (clicked == false)
        {
            renderer.enabled = false;
        }

        //for movement/drag
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 4f*Input.mousePosition.y, screenPoint.z));

    }

    //move the tv
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, 4f*Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.y = lockedYPos;
        transform.position = curPosition;
    }
}