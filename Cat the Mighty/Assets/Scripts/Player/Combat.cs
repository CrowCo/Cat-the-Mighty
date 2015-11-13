using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Combat : MonoBehaviour {

	CameraController cam;
	GameObject target;
	Animator anim;

	public int damage = 120;
	public float timeBetweenBullets = 0.15f;
	public float range = 100f;
	
	Camera cam2;
	float timer;
	Ray shootRay;
	RaycastHit shootHit;
	ParticleSystem gunParticles;
	LineRenderer gunLine;
	AudioSource catAudio;
	Vector3 offset;
	float turnSpeed = 2.0f;

	//Light gunLight;
	//float effectsDisplayTime = 0.2f;

	public List<Transform> targets;
	// Use this for initialization
	void Start () {
		//cam = GetComponent<Camera> ();
		cam = GetComponent <CameraController> ();
		targets = new List<Transform>();
		cam2 = cam.GetComponent <Camera>();
		anim = GetComponent <Animator> ();
		catAudio = GetComponent<AudioSource> ();
		GameObject[] go = GameObject.FindGameObjectsWithTag ("Target");
		foreach(GameObject target in go)
		{
			AddTarget(target.transform);

		}
	}

	void AddTarget(Transform target){
		targets.Add (target);
		GameObject player = GameObject.Find ("Player");
		Transform playerTransform = player.transform;
		// get player position
		Vector3 position = playerTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("z")){
			LockOn(target);
		}
		if(Input.GetKeyDown("v")){
			Attack ();
		}
	}

	void LockOn(GameObject targets) {
		//Vector3 targets = Vector3();
		
		//while(Vector3.Distance(targets.transform.position, transform.position) > 0.1){
			//Vector3 direction = transform.position - targets.transform.position;
			//transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation(direction), 0.2* Time.deltaTime);
			cam2.transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
			//cam2.transform.RotateAround(targets.transform.position, Input.GetAxisRaw ("Horizontal"), offset);
			offset = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
			transform.position = targets.transform.position + offset;
			offset = Quaternion.AngleAxis (Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
			cam2.transform.position = targets.transform.position + offset; 
			cam2.transform.LookAt(targets.transform.position);
			return;
		//}
	}

	void Attack() {
		anim.SetTrigger ("Attack");
		catAudio.Play ();
		shootRay.origin = transform.position;
		shootRay.direction = transform.forward;

		//instantiate hitbox
		//check for collision
		//destroy hitbox
		
		if(Physics.Raycast (shootRay, out shootHit, range))
		{
			EnemyHealth enemyHealth = shootHit.collider.GetComponent <EnemyHealth> ();
			if(enemyHealth != null)
			{
				enemyHealth.TakeDamage (damage, shootHit.point);
			}
			gunLine.SetPosition (1, shootHit.point);
		}
		else
		{
			gunLine.SetPosition (1, shootRay.origin + shootRay.direction * range);
		}
	}
}
