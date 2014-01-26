using UnityEngine;
using System.Collections;

public class portrait : MonoBehaviour
{
    bool clicked = false;
    Vector3 screenPoint;
    Vector3 offset;

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

        //it now talks!!!! WHOOOAAAAAAA I'M FRAAAANK
        if (clicked == false)
        {
            //what to do?
        }
        else if (clicked == true)
        {
            //audio.Play();
            TenantAI.scareCount += 1;
        }

        //for movement/drag
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    //move the portrait
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
}