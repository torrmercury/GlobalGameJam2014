using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
    bool clicked = true;
    bool locked = false;
    Vector3 screenPoint;
    Vector3 offset;
    float lockedYPos;
    float lockedZPos;
    public AudioClip lockDoor;
    public AudioClip unlockDoor;

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
        //lock the door
        if (clicked == true)
        {
            clicked = false;
            locked = false;
            audio.clip = unlockDoor;
            audio.Play();
        }
        else if (clicked == false)
        {
            clicked = true;
            locked = true;
            audio.clip = lockDoor;
            audio.Play();
        }

        
        //if locked character cannot open door
        if (locked == false)
        {
            
        }
        else if (locked == true)
        {
            
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
