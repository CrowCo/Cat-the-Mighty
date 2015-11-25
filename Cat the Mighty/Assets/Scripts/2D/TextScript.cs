using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextScript : MonoBehaviour {
	public Canvas textHUD;
	public Animator anim;
	public GameObject NPC;
	public int scriptNum;
	public TextAsset textFile;
	string[] dialogLines;
	bool TextOpen = true;
	Text dialog;
	//Sprite[] images;


	public float letterPause = 0.2f;
	//public AudioClip typeSound1;
	//public AudioClip typeSound2;
	public string message;

	void Start () {
		textHUD = textHUD.GetComponent<Canvas> ();
		//anim = gameObject.GetComponent<Animator> ();
		anim.SetBool ("TextOpen", TextOpen);
		dialog = GetComponent<Text>();
		
		// Make sure there this a text
		// file assigned before continuing
		if(textFile != null)
		{
			// Add each line of the text file to
			// the array using the new line
			// as the delimiter
			dialogLines = ( textFile.text.Split( '\n' ) );

		}
		// Assign the first string
		// in the array to a variable
		string message = dialogLines[scriptNum];
		//dialog.text = message;
		dialog.text = dialogLines[scriptNum];
		dialog.text = "";

		StartCoroutine(TypeText ());
	}


	void Update () {
		if (Input.GetKeyDown ("t")) {
			scriptNum++;
			dialog.text = dialogLines[scriptNum];
			message = dialog.text;
			dialog.text = "";

			StartCoroutine(TypeText ());
		}

		if (scriptNum == 2) {
			ChangeFace(NPCEmotionController.EmotionType.ANGER);
		}

		if (scriptNum == dialogLines.Length) {
			anim.SetBool ("TextOpen", false);
		}


	}

	IEnumerator TypeText () {
		foreach (char letter in message.ToCharArray()) {
			dialog.text += letter;
			yield return 0;
			yield return new WaitForSeconds (letterPause);
		}

		StopCoroutine(TypeText());
	}
	void GetButtonResult () {
		
		/*Find the buttons in the screen, turn them on
		 * 
		 * Stop the text from continuing
		 * 
		 * Get the results of the button press
		 * 
		 * start printing the lines of text from there
		 * if(1)
		 * +1 message
		 * +1
		 * 
		 * if(2)
		 * +2 message
		 * 
		 * Reenable the text
		 */
		
	}

	void ChangeFace (NPCEmotionController.EmotionType faceNumber) {
		
		NPC.GetComponent<NPCEmotionController>().ChangeEmotion(faceNumber);
		
	}
}