using UnityEngine;
using System.Collections;

public class ButtonSelect : MonoBehaviour {
	
	string[] buttonNames = {"New Game", "Load", "Exit"};
	bool[] buttons;
	int currentSelection = 0;    // current button selected
	
	void Start() {
		buttons = new bool[buttonNames.Length];
	}
	
	void OnGUI() {
		// Generate buttons, store into buttons array
		for (int i = 0; i < buttonNames.Length; i++) {
			GUI.SetNextControlName(buttonNames[i]);
			buttons[i] = GUI.Button(new Rect(10, 70 + (20 * i), 80, 20), buttonNames[i]);
		}
		
		// Using button with keystroke
		if (Input.GetButton("Use")) {
			// When the use key is pressed, the selected button will activate
			buttons[currentSelection] = true;
		}
		
		// Button conditions
		if (buttons[0]) {
			// resume
		}
		
		if (buttons[1]) {
			// return to main menu
		}

		if (buttons[2]) {
			// quit game
		}
		
		// Cycling through buttons
		if (Input.GetButton("Down")) {
			GUI.FocusControl(buttonNames[currentSelection + 1]);
		}
		if (Input.GetButton("Up")) {
			GUI.FocusControl(buttonNames[currentSelection - 1]);
		}
	}
}
