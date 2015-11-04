using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float walkSpeed = 20f;
	public float runSpeed = 50f;
	public float rollSpeed = 200f;
	public float speed = 5f;
	Vector3 movement;
	Animator anim;
	Rigidbody rb;
	int JumpHeight = 1600;
	float gravity = -50f;
	AudioSource catAudio;

	public bool IsGrounded;
	//private AnimatorStateInfo currentBaseState;
	
	void Awake(){
		anim = GetComponent <Animator> ();
		rb = GetComponent <Rigidbody> ();
		catAudio = GetComponent<AudioSource> ();
	}
	void Update(){
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		if (Input.GetKey ("left shift")) {
			speed = walkSpeed;
		}
		if (Input.GetKeyDown("space")){
			Jump ();
		} 
		
		//currentBaseState = anim.GetCurrentAnimatorStateInfo(0);
		rb.AddForce(movement * speed);
		Physics.gravity = new Vector3(0, gravity, 0);
		//movement.y -= gravity * Time.deltaTime;
		Move (moveHorizontal,moveVertical);
		Turning (moveHorizontal, moveVertical);
		Animating (moveHorizontal,moveVertical);


	}
	
	void Move (float h, float v){
		movement.Set (h,0f,v);
		movement = movement.normalized * speed * Time.deltaTime;
		rb.MovePosition (transform.position + movement);
	}
	public void Jump(){
		if (IsGrounded) {
			anim.SetTrigger ("Jump");
			catAudio.Play ();
			rb.AddForce(Vector3.up * JumpHeight);
			IsGrounded = false;
		}
	}

	void OnCollisionStay(Collision collisionInfo) {
		//we are on something
		if ( CollisionFlags.CollidedBelow != 0)
		{
			IsGrounded = true;
		}

	}
	
	void Turning(float h, float v){
		bool walking = h !=0f || v !=0f;
		if (walking) {
			transform.forward = Vector3.Normalize(new Vector3(h, 0f,v));
		}
	}
	
	
	void Animating(float h, float v){
		bool walking = h !=0f || v !=0f;
		anim.SetBool ("IsWalking", walking);
		speed = walkSpeed;
		if (Input.GetKeyDown ("r")) {
			anim.SetTrigger ("Roll");
			speed = rollSpeed;
		}
	}
	
}