using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextScript : MonoBehaviour {
	public Canvas textHUD;
	public Animator anim;
	public string[] script;
	public GameObject NPC;
	public int scriptNum;
	bool TextOpen = true;
	Text dialog;
	//Sprite[] images;


	public float letterPause = 0.2f;
	//public AudioClip typeSound1;
	//public AudioClip typeSound2;
	string message;

	void Start () {
		textHUD = textHUD.GetComponent<Canvas> ();
		//images = gameObject.GetComponentsInChildren<Sprite>();
		//anim = gameObject.GetComponent<Animator> ();
		anim.SetBool ("TextOpen", TextOpen);
		dialog.text = script[0];
		message = dialog.text;
		dialog.text = "";
		StartCoroutine(TypeText ());
	}


	void Update () {
		if (Input.GetKeyDown ("t")) {
			dialog = GetComponent<Text>();
			scriptNum++;
			dialog.text = script[scriptNum];
			message = dialog.text;
			dialog.text = "";

			StartCoroutine(TypeText ());
		}

		if (scriptNum == 2) {
			ChangeFace(NPCEmotionController.EmotionType.ANGER);
		}

		if (scriptNum == script.Length) {
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

	void ChangeFace (NPCEmotionController.EmotionType faceNumber) {
		
		NPC.GetComponent<NPCEmotionController>().ChangeEmotion(faceNumber);
		
	}
}