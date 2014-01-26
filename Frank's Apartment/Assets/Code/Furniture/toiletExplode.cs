using UnityEngine;
using System.Collections;

public class toiletExplode : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	if (toilet.toiletClicked)
        {
            renderer.enabled = true;
        }
    else if (!toilet.toiletClicked)
        {
            renderer.enabled = false;
        }
	}
}
