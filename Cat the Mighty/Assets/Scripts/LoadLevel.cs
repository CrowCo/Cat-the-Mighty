using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public GameObject player;
	public int levelskip;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject == player) {
			Application.LoadLevel (0 + levelskip);
		}
	}
}
