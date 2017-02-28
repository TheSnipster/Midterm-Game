using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// controls checklist
//checks if all the items in the checklist is checked => sth happens

public class checklistScript : MonoBehaviour
{

	[SerializeField]

	public Toggle butterToggle;
	public Toggle flourToggle;
	public Toggle milkToggle;
	public Toggle sugarToggle;
	public Toggle eggToggle;
	public Toggle saltToggle;
	public Toggle sparkleToggle;

	public Text winText;

	public GameObject bowl;
	public GameObject cake;


	// Use this for initialization
	void Start ()
	{
		//winText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	//	void Update () {
	//		if (butterToggle.isOn && flourToggle.isOn && milkToggle.isOn && sugarToggle.isOn && eggToggle.isOn && saltToggle.isOn &&sparkleToggle.isOn) {
	//			winText.text = "THE CAKE IS A LIE!";
	//		} else {
	//			winText.text = null;
	//		}
	//	}
	//
	//	IEnumerator CakeAppear(){
	//		if (winText.text == "THE CAKE IS A LIE!"){
	//			yield return new WaitForSeconds (2);
	//			Destroy(bowl.gameObject);
	//
	//			Instantiate(cake, bowl.transform.position, bowl.transform.rotation);
	//		}
	//	}

	IEnumerator CakeAppear ()
	{
		if (butterToggle.isOn && flourToggle.isOn && milkToggle.isOn && sugarToggle.isOn && eggToggle.isOn && saltToggle.isOn && sparkleToggle.isOn) {
			winText.text = "THE CAKE IS A LIE!";
			yield return new WaitForSeconds (2);
		
			GameObject LieCake = Instantiate (cake, bowl.transform.position, bowl.transform.rotation);
			Destroy (bowl.gameObject);

		} else {
			winText.text = null;

		}
	}

}
