using UnityEngine;
using System.Collections;

public class spring : MonoBehaviour {
    private Animation Animation;

	// Use this for initialization
	void Start () {
        //StartCoroutine("Spring");
        Animation = GetComponent<Animation>();
	}
	
	// Update is called once per frame
    void Update()
    {
        Debug.Log("test");
        if (couch.couchClicked == false && Animation.isPlaying == true)
        {
            //Animation.Stop();
            //Animation.Rewind("Spring");
        }
        
        else if (couch.couchClicked == true && Animation.isPlaying == false)
        {
            Animation.Play("Spring");
            couch.couchClicked = false;
        }
        
    }
}