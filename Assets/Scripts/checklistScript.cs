using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// controls checklist
//checks if all the items in the checklist is checked => sth happens 

public class checklistScript : MonoBehaviour {

	[SerializeField]

	Toggle butterToggle;
	Text winText;

	// Use this for initialization
	void Start () {
		winText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetToggles(){
		if (butterToggle.isOn) {
			winText.text = "THE CAKE IS A LIE!";
		}
	}


}
