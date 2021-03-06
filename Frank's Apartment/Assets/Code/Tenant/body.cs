﻿using UnityEngine;
using System.Collections;

public class body : MonoBehaviour {

    Vector3 screenPoint;
    Vector3 offset;
    float lockedYPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //makes the body jump a little bit
    void OnMouseDown()
    {
        //play animation

        TenantAI.scareCount += 1;

        //for movement/drag
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 4f * Input.mousePosition.y, screenPoint.z));

    }

    //move the tv
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, 4f * Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.y = lockedYPos;
        transform.position = curPosition;
    }
}
