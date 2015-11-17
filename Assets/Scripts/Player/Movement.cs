using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	[SerializeField]
	private	RigidBody playerBody;
	private float minAxisInput;
	private float speed;
	private float maxSpeed;
	private float jumpForce;
	private float moveForce;

	// Use this for initialization
	void Awake () {
		minAxisInput = 0.3f;
		maxSpeed = 5f;
		jumpForce = 75f;
	}
	
	// Update is called once per frame
	void Update () {
		speed = playerBody.velocity.magnitude;
		Move ();
		Jump();
	}

	void Move(){
		if (Mathf.Abs (Input.GetAxisRaw(FU.Controls.Forward))>minAxisInput && speed<maxSpeed){
			playerBody.AddForce( moveForce * Vector3.forward );
		}
		if (Mathf.Abs (Input.GetAxisRaw(FU.Controls.Sideways))>minAxisInput && speed<maxSpeed){
			playerBody.AddForce( moveForce * Vector3.right );
		}
	}

	void Jump(){
		if (Input.GetButtonDown (FU.Controls.Jump)){
			playerBody.AddForce (jumpForce * Vector3.up);
		}
	}


}
