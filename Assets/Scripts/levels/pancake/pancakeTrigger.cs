using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pancakeTrigger : MonoBehaviour
{
	//put on trigger
	public Collider bowlFilter;
	public Collider ingredient;
	//	public Collider bowlSide1;
	//	public Collider bowlSide2;
	//	public Collider bowlSide3;
	//	public Collider bowlSide4;
	//
	int butterCount = 0;
	int flourCount = 0;
	int milkCount = 0;
	int eggCount = 0;
	int saltCount = 0;
	int syrupCount = 0;

	public Toggle butterToggle;
	public Toggle flourToggle;
	public Toggle milkToggle;
	public Toggle eggToggle;
	public Toggle saltToggle;
	public Toggle syrupToggle;

	public GameObject crack;


	// Use this for initialization
	void Start ()
	{

	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Butter") {
			butterCount++;
			ingredient = other;
			ingredient.transform.SetParent (transform);
//			GameObject.FindGameObjectWithTag ("Butter").SetActive (false); 
//			crack.SetActive(true);
			if (butterCount == 1) {
				butterToggle.isOn = true;
			}

		}
		if (other.tag == "Flour") {
			flourCount++;
			ingredient = other;
			ingredient.transform.SetParent (transform);
			if (flourCount == 2) {
				flourToggle.isOn = true;
			}
		}

		if (other.tag == "Milk") {
			milkCount++;
			ingredient = other;
			ingredient.transform.SetParent (transform);
			if (milkCount == 2) {
				milkToggle.isOn = true;
			}
		}

		if (other.tag == "Eggs") {
			eggCount++;
			ingredient = other;
			ingredient.transform.SetParent (transform);
			if (eggCount == 3) {
				eggToggle.isOn = true;
			}
		}

		if (other.tag == "Salt") {
			saltCount++;
			ingredient = other;
			ingredient.transform.SetParent (transform);
			if (saltCount == 1) {
				saltToggle.isOn = true;
			}
		}

		if (other.tag == "Syrup") {
			syrupCount++;
			ingredient = other;
			ingredient.transform.SetParent (transform);
			if (syrupCount == 1) {
				syrupToggle.isOn = true;
			}
		}




		//	void OnTriggerStay (Collider other){
		//		bowlBottom = other;
		//		bowlBottom.transform.SetParent (transform); //parent the other thing to us
		//
		//		bowlSide1 = other;
		//		bowlSide1.transform.SetParent (transform); //parent the other thing to us
		//
		//		bowlSide2 = other;
		//		bowlSide3.transform.SetParent (transform); //parent the other thing to us
		//
		//		bowlSide3 = other;
		//		bowlSide3.transform.SetParent (transform); //parent the other thing to us
		//
		//		bowlSide4 = other; 
		//		bowlSide4.transform.SetParent (transform); //parent the other thing to us
		//
		//	
	}
}