using UnityEngine;
using System.Collections;

public class tvScreen : MonoBehaviour
{
    Vector3 screenPoint;
    Vector3 offset;
    bool clicked = false;
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
    }

    //move the 
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}