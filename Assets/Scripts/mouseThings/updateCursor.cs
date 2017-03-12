using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateCursor : MonoBehaviour {

	CursorControl cursor; 
	bool carrying;

	// Use this for initialization
	void Start () {
		cursor = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<CursorControl> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (carrying) {
			cursor.setGrab();
		}
	}

	void OnMouseEnter(){
		cursor.setHover();
	}

	void OnMouseExit(){
		cursor.setMouse();
	}

	void OnMouseDown(){
		carrying = true; 
	}

	void OnMouseUp(){
		carrying = false; 
		cursor.setMouse();
	}
}
