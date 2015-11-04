using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	Canvas pause;

	// Use this for initialization
	void Start () {
		Canvas pause = GetComponent <Canvas> ();
		pause.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("p")){
			pause.enabled = true;
		}
	
	}
}
