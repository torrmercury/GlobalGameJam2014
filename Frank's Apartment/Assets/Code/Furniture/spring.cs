using UnityEngine;
using System.Collections;

public class spring : MonoBehaviour {
    private Animation Animation;
    public spring spawnspring;

	// Use this for initialization
	void Start () {
        //StartCoroutine("Spring");
        Animation = GetComponent<Animation>();
	}
	
	// Update is called once per frame
    void Update()
    {
        if (couch.couchClicked == true && Animation.isPlaying == false)
        {
            Animation.Play("Spring");
            couch.couchClicked = false;
            StartCoroutine("SpringGo");
        }
    }

    IEnumerator SpringGo()
    {
        Vector3 origPos = transform.position;
        Debug.Log(origPos);
        yield return new WaitForSeconds(3f);
        spring newspring;
        newspring = Instantiate(spawnspring, origPos, Quaternion.identity) as spring;
        Destroy(gameObject);
    }
}