using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextRead : MonoBehaviour 
{
	public Canvas textHUD;
	public Animator anim;
	public int scriptNum = 0;
	bool TextOpen = true;
	Text dialog;
	public TextAsset textFile;
	string[] dialogLines;
	public string message;
	
	// Use this for initialization
	void Start () 
	{
		textHUD = textHUD.GetComponent<Canvas> ();
		anim.SetBool ("TextOpen", TextOpen);

		// Make sure there this a text
		// file assigned before continuing
		if(textFile != null)
		{
			// Add each line of the text file to
			// the array using the new line
			// as the delimiter
			dialogLines = ( textFile.text.Split( '\n' ) );
			// Assign the first string
			// in the array to a variable
			string message = dialogLines[scriptNum];
			dialog.text = message;
		}
	}

	void Update () {
		if (Input.GetKeyDown ("t")) {
			dialog = GetComponent<Text>();
			scriptNum++;
			string message = dialogLines[2];
			dialog.text = message;
			//dialog.text = dialogLines[scriptNum];
		}
	
		if (scriptNum == dialogLines.Length) {
			anim.SetBool ("TextOpen", false);
		}
	
	
	}
}