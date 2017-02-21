using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//move forward
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0f, 0f, 5f * Time.deltaTime); //movement relative to rotation
		}

		//turn right
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.localEulerAngles += new Vector3 (0f, 90f * Time.deltaTime, 0f);
		}

		//turn left
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.localEulerAngles += new Vector3 (0f, -90f * Time.deltaTime, 0f); 
		}

		//move backwards
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0f, 0f, -5f * Time.deltaTime);
		}


	}
}
