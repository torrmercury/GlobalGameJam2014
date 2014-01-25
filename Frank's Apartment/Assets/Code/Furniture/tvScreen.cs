using UnityEngine;
using System.Collections;

public class tvScreen : MonoBehaviour
{
    bool clicked = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //turn the screen on/off
        if (clicked == true)
        {
            renderer.enabled = true;
        }

        else if (clicked == false)
        {
            renderer.enabled = false;
        }
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
    }
}