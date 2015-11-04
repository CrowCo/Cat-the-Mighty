﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExitMenu : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button exitText;


	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent <Canvas> ();	
		startText = startText.GetComponent <Button> ();
		exitText = exitText.GetComponent <Button> ();
		quitMenu.enabled = false;
	}

	public void exitPress(){
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}

	public void noPress(){
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void startLevel(){
		Application.LoadLevel ("Shop_01");
	}

	public void LoadLevel(){
		Application.LoadLevel ("Load_screen");
	}

	public void exitGame(){
		Application.Quit ();
	}
}
