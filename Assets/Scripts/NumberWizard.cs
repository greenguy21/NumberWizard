using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	//Vars
	int max, min, guess;


	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame(){
		max = 1000;
		min = 1;
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but don't tell me");
		print ("High: " + max + " Low: " + min);
		max++;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Up Pressed");
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Down Pressed");
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Found it!");
			StartGame ();
		}
	}

	void NextGuess (){
		guess = (min + max) / 2;
		print ("Higher or lower than " + guess);
	}
}
