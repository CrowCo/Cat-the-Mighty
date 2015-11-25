using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public Canvas pause;
	bool enabled;
	// Use this for initialization
	void Start () {
		Canvas pause = GetComponent<Canvas> ();
		pause.enabled = false;
		enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("p")){
			if(enabled = true){
				pause.enabled = false;
				enabled = false;
			}
			else{
				pause.enabled = true;
				enabled = false;
			}
		}
	
	}
}
