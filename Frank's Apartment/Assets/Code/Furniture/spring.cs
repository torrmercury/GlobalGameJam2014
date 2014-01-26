using UnityEngine;
using System.Collections;

public class spring : MonoBehaviour {
    //private Animation Animation;
    public spring spawnspring;
    int count = 0;

	// Use this for initialization
	void Start () {
        //StartCoroutine("Spring");
        /*Animation = GetComponent<Animation>();
        Animation.Stop();*/
	}
	
	// Update is called once per frame
    void Update()
    {
        if (couch.couchClicked && !animation.isPlaying)
        {
            count++;
            Debug.Log(count.ToString());
            animation.Play();
            audio.Play();
            couch.couchClicked = false;
            StartCoroutine("SpringReset");
            Debug.Log(couch.couchClicked);
        }
        //Debug.Log("update works");
    }

    IEnumerator SpringReset()
    {
        yield return new WaitForSeconds(3f);
        animation.Stop();
        animation.Rewind();
        couch.couchClicked = false;
        Debug.Log(couch.couchClicked);
    }
}