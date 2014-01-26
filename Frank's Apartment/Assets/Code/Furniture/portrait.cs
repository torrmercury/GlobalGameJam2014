using UnityEngine;
using System.Collections;

public class portrait : MonoBehaviour
{
    bool clicked = false;
    Vector3 screenPoint;
    Vector3 offset;
    int whatFranksay;
    public AudioClip onSound;
    public AudioClip offSound;
    public AudioClip maintain;

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
        //it now talks!!!! WHOOOAAAAAAA I'M FRAAAANK

        if (clicked == false)
        {
            clicked = true;
            Invoke("off", 0f);
        }
        else if (clicked == true)
        {
            clicked = false;
            Invoke("on", 0f);
            Invoke("staticPlay", .6f);
            TenantAI.scareCount += 1;
        }
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
}