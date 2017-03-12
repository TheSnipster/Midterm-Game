using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// controls PANCAKE checklist
//checks if all the items in the checklist is checked => sth happens

public class pancakeChecklist : MonoBehaviour
{

	[SerializeField]

	public Toggle butterToggle;
	public Toggle flourToggle;
	public Toggle milkToggle;
	public Toggle eggToggle;
	public Toggle saltToggle;
	public Toggle syrupToggle;

	public Text winText;

	public GameObject bowl;
	public GameObject pancake;

	bool isBowlGone = false;

	float secondsCount = 0f;

	// Use this for initialization
	void Start ()
	{
		//winText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (butterToggle.isOn && flourToggle.isOn && milkToggle.isOn && eggToggle.isOn && saltToggle.isOn && syrupToggle.isOn) {
			isBowlGone = true;
			PancakeAppear ();
			if (isBowlGone == true) {
				secondsCount += Time.deltaTime;
				Debug.Log (secondsCount);
			}

		} else {
			//winText.text = null; 
		}
	}

	void PancakeAppear ()
	{
		if (secondsCount > 2f) {
			pancake.gameObject.SetActive (true);
			//Instantiate (cake, bowl.transform.position, bowl.transform.rotation);
			if (bowl.gameObject != null) {
				bowl.gameObject.SetActive (false);
			}

			if (secondsCount > 4f) {
				winText.text = "YOU MADE PANCAKES!";

				if (secondsCount > 9f) {
					SceneManager.LoadScene (4);
				}

			}
		}

	}
}


//secondsCount += Time.deltaTime;
//isBowlGone == false

//		IEnumerator CakeAppear(){
//		if (winText.text = !null) {
//			yield return new WaitForSeconds (2);
//
//
//			Instantiate (cake, bowl.transform.position, bowl.transform.rotation);
//			Destroy (bowl.gameObject);
//		}
//	}

//	IEnumerator CakeAppear ()
//	{
//		if (butterToggle.isOn && flourToggle.isOn && milkToggle.isOn && sugarToggle.isOn && eggToggle.isOn && saltToggle.isOn && sparkleToggle.isOn) {
//			winText.text = "THE CAKE IS A LIE!";
//			yield return new WaitForSeconds (2);
//
//			GameObject LieCake = Instantiate (cake, bowl.transform.position, bowl.transform.rotation);
//			Destroy (bowl.gameObject);
//
//		} else {
//			winText.text = null;
//
//		}
//	}

