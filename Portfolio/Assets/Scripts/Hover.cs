using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour {

	Vector3 originalPosition;
	int direction = 1;

	public float speed = 1.0f;
	public float how_much = 0.5f;

	void Start () {
		originalPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y > originalPosition.y * (1 + how_much))
			direction = -1;
		if (transform.position.y < originalPosition.y * (1 - how_much))
			direction = 1;
		
		transform.Translate(0, direction*speed*Time.deltaTime,0);
	}
}
