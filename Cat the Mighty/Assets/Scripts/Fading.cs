using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour {
	public Texture2D fadeTexture;
	public float fadeSpeed = 0.8f;
	public GameObject player;

	private int drawDepth = -1000;
	private float alpha = 1.0f; 
	private int fadeDir = -1;
	
	void Start () {
		player = GameObject.FindGameObjectWithTag ("player");
		player.GetComponent<CharacterController> ();
		
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.gameObject == player) {
			beginFade(1);
			Application.LoadLevel ("scene_02");
			onLevelLoad();
		}
	}

	void onGUI() {
		alpha = fadeSpeed * fadeDir * Time.deltaTime;
		alpha = Mathf.Clamp01 (alpha);
		GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b);
		GUI.depth = drawDepth;
		//GUI.DrawTexture (fadeTexture);
	}

	public float beginFade (int direction){
		fadeDir = direction;
		return (fadeSpeed);
	}

	void onLevelLoad(){
		beginFade(-1);
	}
}
