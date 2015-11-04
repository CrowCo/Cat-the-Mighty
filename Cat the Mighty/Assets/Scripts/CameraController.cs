using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	float turnSpeed = 2.0f;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		offset = transform.position - player.transform.position;
	}
	
	void LateUpdate () {
		//Turns cam around object

		//offset = Quaternion.AngleAxis (Input.GetAxisRaw ("Horizontal") * turnSpeed, Vector3.up) * offset;

		transform.position = player.transform.position + offset; 
		transform.LookAt(player.transform.position);
	}
}
