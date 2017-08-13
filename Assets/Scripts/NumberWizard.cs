using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	string maxString;
	int min;
	Random rdm;
	int guess;
	int max;
	/*string i;*/

	// Use this for initialization
	void Start () {
		StartGame();
	}

	/*void inputGuess() {
		print ("Please enter the maximum number you want to be able to choose");
		i = Input.inputString;
		int.TryParse(i, out guess);
		if (guess.GetType() == typeof(int)) {
			guess = guess;
		} else {
			print ("That's not a valid number!");
			inputGuess();
		}
	}*/

	void maxStringInput() {
		print ("Enter the desired maximum number you can choose! Press ESC when you're done");
		while (true) {
			if (Input.GetKeyDown(KeyCode.Keypad0)) {
				if (maxString == "") {
					print ("You can't start with a zero! Try again");
					maxStringInput();
				} else if (maxString != "") {
					maxString += "0";
					print ("Your current number is: " + maxString + "! If you're happy with that press ESC to set the number = maximum");
					maxStringInput();
				}
				} else if (Input.GetKeyDown(KeyCode.Keypad1)) {
					maxString += "1";
					print ("Your current number is: " + maxString + "! If you're happy with that press ESC to set the number = maximum");
					maxStringInput();
				} else if (Input.GetKeyDown(KeyCode.Keypad2)) {
					maxString += "2";
					print ("Your current number is: " + maxString + "! If you're happy with that press ESC to set the number = maximum");
					maxStringInput();
				} else if (Input.GetKeyDown(KeyCode.Keypad3)) {
					maxString += "3";
					print ("Your current number is: " + maxString + "! If you're happy with that press ESC to set the number = maximum");
					maxStringInput();
				} else if (Input.GetKeyDown(KeyCode.Keypad4)) {
					maxString += "4";
					print ("Your current number is: " + maxString + "! If you're happy with that press ESC to set the number = maximum");
					maxStringInput();
				} else if (Input.GetKeyDown(KeyCode.Keypad5)) {
					maxString += "5";
					maxStringInput();
				} else if (Input.GetKeyDown(KeyCode.Keypad6)) {
					maxString += "6";
					print ("Your current number is: " + maxString + "! If you're happy with that press ESC to set the number = maximum");
					maxStringInput();
				} else if (Input.GetKeyDown(KeyCode.Keypad7)) {
					maxString += "7";
					print ("Your current number is: " + maxString + "! If you're happy with that press ESC to set the number = maximum");
					maxStringInput();
				} else if (Input.GetKeyDown(KeyCode.Keypad8)) {
					maxString += "8";
					maxStringInput();
				} else if (Input.GetKeyDown(KeyCode.Keypad9)) {
					maxString += "9";
					print ("Your current number is: " + maxString + "! If you're happy with that press ESC to set the number = maximum");
					maxStringInput();
				} else if (Input.GetKeyDown (KeyCode.Escape)) {
					max = int.Parse(maxString);
					break;
				} else {
					print ("Thats not an option! Try again");
			}
		}	
	}
	
	void StartGame () {
		min = 1;
		maxString = "";
		maxStringInput();
		guess = max / 2;



		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The lowest number you can pick is " + min);
		print ("The highest number you can pick is " + max);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow = higher, down = lower, return = equal");


		//inputGuess();

		max = max + 1;
	} 

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
			//"Starting" new game
			print ("==========================");
			StartGame ();
		}
	}

	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("Up arrow = higher, down = lower, return = equal");
	}
}
