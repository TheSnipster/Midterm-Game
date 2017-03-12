using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script causes the object to pass thru the terrain and partially thru each other 

public class mouseDrag : MonoBehaviour { //this script causes the object to pass thru the
	float distance = 60;

	void OnMouseDrag(){
		Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 20f, distance);

		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

		transform.position = objPosition;

	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
