using UnityEngine;
using System.Collections;

public class animationFlip : MonoBehaviour {

	float startPosition;
	float thisFrame;

	// Use this for initialization
	void Start () {
		startPosition = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {

		if (thisFrame - transform.position.x <= 0) {
			Vector3 tempScale = transform.localScale;
			tempScale.x = (tempScale.x) * -1;
			transform.localScale = tempScale;
		}


		thisFrame = transform.position.x;

	}
}
