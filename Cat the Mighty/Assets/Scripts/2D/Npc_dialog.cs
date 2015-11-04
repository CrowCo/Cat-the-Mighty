using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Npc_dialog : MonoBehaviour {

	public Canvas ChoiceButtons;
	public string[] responses = new string[4];
	public string[] answers = new string[4];
	public Button choice1;
	public Button choice2;
	int index;
	public GameObject TextBox;
	//TextScript text;
	Text dialog;
	Text text1;
	Text text2;

	//Text choiceName;
	// Use this for initialization
	void Start () {
		dialog = TextBox.GetComponent<Text>();

		ChoiceButtons = ChoiceButtons.GetComponent <Canvas> ();
		text1 = choice1.GetComponentInChildren <Text> ();
		text2 = choice2.GetComponentInChildren <Text> ();
		answers [0] = "And the winner is...Marth!";
		answers [1] = "Okay";
		answers [2] = "No.";
		answers [3] = "Maybe?";

		responses [0] = "Figured as much. Out. Now.";
		responses [1] = "Well, you must think I'm blind. Glad to know you think that much of me.";
		responses [2] = "No.";
		responses [3] = "Maybe?";
	}
	
	// Update is called once per frame
	void Update () {
		text1.text = answers[1];
		text2.text = answers[2];
	}

	public void Press1(){
		dialog.text = responses[0];
		//ChoiceButtons.enabled = false;
		ChoiceButtons.enabled = false;
		choice1.enabled = false;
		choice2.enabled = false;
	}
	
	public void Press2(){
		dialog.text = responses[1];
		//ChoiceButtons.enabled = false;
		ChoiceButtons.enabled = false;
		choice1.enabled = false;
		choice2.enabled = false;
	}
}
