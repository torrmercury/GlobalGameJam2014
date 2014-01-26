using UnityEngine;
using System.Collections;

public class spring : MonoBehaviour {
    private Animation Animation;
    public spring spawnspring;

	// Use this for initialization
	void Start () {
        //StartCoroutine("Spring");
        Animation = GetComponent<Animation>();
        Animation.Stop();
	}
	
	// Update is called once per frame
    void Update()
    {
        
        if (couch.couchClicked == true && Animation.isPlaying == false)
        {
            Animation.Play("Spring");
            couch.couchClicked = false;
            StartCoroutine("SpringReset");
            Debug.Log("If statement works");
        }
        //Debug.Log("update works");
    }

    IEnumerator SpringReset()
    {
        yield return new WaitForSeconds(3f);
        Animation.Rewind();
        Debug.Log("coroutine works");
    }
}