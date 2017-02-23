using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRaycast : MonoBehaviour {

	Collider currentlyHeld;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);

		RaycastHit rayHit = new RaycastHit ();

		Debug.DrawRay (ray.origin, ray.direction * 5f, Color.cyan);

		if (Physics.Raycast (ray, out rayHit, 20f)) {
			if (Input.GetMouseButtonDown (0)) {
				currentlyHeld = rayHit.collider;
				currentlyHeld.transform.parent = Camera.main.transform;
			}
		}

		if (Input.GetMouseButtonDown (0) == false && currentlyHeld != null) {
			currentlyHeld.transform.parent = null;
			currentlyHeld = null; 
		}

	}
}
