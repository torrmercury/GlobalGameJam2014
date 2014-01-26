using UnityEngine;
using System.Collections;

public class tvScreen : MonoBehaviour
{
    Vector3 screenPoint;
    Vector3 offset;
    bool clicked = false;
    float lockedYPos = 1.2f;
    public AudioClip onSound;
    public AudioClip offSound;
    public AudioClip maintain;

    // Use this for initialization
    void Start()
    {
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        //was it clicked?
        //it now talks!!!! WHOOOAAAAAAA I'M FRAAAANK

        if (clicked == false)
        {
            clicked = true;
            Invoke("off", 0f);
            renderer.enabled = true;
            TenantAI.scareCount += 1;
        }
        else if (clicked == true)
        {
            clicked = false;
            Invoke("on", 0f);
            Invoke("staticPlay", .6f);
            renderer.enabled = false;
        }
        
        //for movement/drag
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 4f*Input.mousePosition.y, screenPoint.z));

    }

    void on()
    {
        audio.clip = onSound;
        audio.Play();
    }

    void off()
    {
        audio.clip = offSound;
        audio.Play();
    }

    void staticPlay()
    {
        audio.clip = maintain;
        audio.Play();
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