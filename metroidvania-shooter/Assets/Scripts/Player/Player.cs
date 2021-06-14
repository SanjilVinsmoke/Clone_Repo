using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehavoirSingletion<Player>
{
	private CharacterController2D controller;
	private Animator animator;
	
	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;
	bool isClimbing = false;
	Rigidbody2D rigidbody;
	protected override void Awake()
	{
		base.Awake();
		controller = GetComponent<CharacterController2D>();
		animator = GetComponentInChildren<Animator>();
		rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update()
	{
		
		horizontalMove = Input.GetAxisRaw("Horizontal") * Setting.runSpeed;
		float verticalMove = Input.GetAxisRaw("Vertical") * Setting.climbSpeed; 
		if (isClimbing) { 

			
				rigidbody.velocity = new Vector2(horizontalMove/4, verticalMove);
			rigidbody.gravityScale = 0;
			return;
        }
        else
        {
			//rigidbody.velocity = Vector3.zero;

			rigidbody.gravityScale = 4f;
		}
		animator.SetFloat(Setting.speed, Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool(Setting.isJumping, true);
		}

		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			crouch = true;
		}
		else if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			crouch = false;
		}

	}

	public void OnLanding()
	{
		animator.SetBool(Setting.isJumping, false);
	}

	public void OnCrouching(bool isCrouching)
	{
		animator.SetBool(Setting.isCrouching, isCrouching);
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Ladder"))
		{
			isClimbing = true;
		}
	}
	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.CompareTag("Ladder"))
		{
			isClimbing = false;
		}
	}
	void FixedUpdate()
	{
		if (isClimbing) return;

		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump,horizontalMove);
		jump = false;
		
		
		
	}
}
