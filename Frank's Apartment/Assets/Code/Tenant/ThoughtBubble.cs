using UnityEngine;
using System.Collections;

public class ThoughtBubble : MonoBehaviour {

	// Use this for initialization
	void Start () {
      //  renderer.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(Camera.main.transform);
	    if (TenantAI.newGoal == true)
        {
            StartCoroutine("Bubble");
        }
    }

    IEnumerable Bubble()
    {
        renderer.enabled = true;
        audio.Play();
        yield return new WaitForSeconds(3.5f);
	}

}