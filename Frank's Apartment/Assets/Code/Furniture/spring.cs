using UnityEngine;
using System.Collections;

public class spring : MonoBehaviour {
    Animation Animation;

	// Use this for initialization
	void Start () {
        //StartCoroutine("Spring");
        Animation = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (couch.couchClicked == true)
        {
            Animation.Play();
            couch.couchClicked = false;
        }
	}
    /*
    //Spring bounces for a few seconds
    IEnumerable Spring()
    {
        
        yield return new WaitForSeconds(3.5f);
    }*/
}