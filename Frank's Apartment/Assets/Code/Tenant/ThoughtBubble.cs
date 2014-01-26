using UnityEngine;
using System.Collections;

public class ThoughtBubble : MonoBehaviour {

	// Use this for initialization
	void Start () {
      //  renderer.enabled = false;
		transform.LookAt (Camera.main.transform);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (TenantAI.newGoal == true)
        {
            StartCoroutine("Bubble");
        }
    }

    IEnumerable Bubble()
    {
        renderer.enabled = true;
        //play audio
        yield return new WaitForSeconds(3.5f);
	}

}