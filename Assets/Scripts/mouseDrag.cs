﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseDrag : MonoBehaviour {
	float distance = 45;

	void OnMouseDrag(){
		Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y + 5f, distance);

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
