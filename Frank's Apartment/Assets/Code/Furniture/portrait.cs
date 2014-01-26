using UnityEngine;
using System.Collections;

public class portrait : MonoBehaviour
{
    bool clicked = false;
    Vector3 screenPoint;
    Vector3 offset;
    int whatFranksay;
    public AudioClip franku;
    public AudioClip lazer;
    public AudioClip ded;

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
        }
        else if (clicked == true)
        {
            clicked = false;
            whatFranksay = Random.Range(0, 3);
            if (whatFranksay == 0)
            {
                audio.clip = franku;
            }
            else if (whatFranksay == 1)
            {
                audio.clip = ded;
            }
            else if (whatFranksay == 2)
            {
                audio.clip = lazer;
            }
            audio.Play();
            TenantAI.scareCount += 1;
        }
    }
}