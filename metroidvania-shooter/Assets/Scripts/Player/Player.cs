using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehavoirSingletion<Player>
{
	private CharacterController2D controller;
	private Animator animator;
	
	public float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	protected override void Awake()
	{
		base.Awake();
		controller = GetComponent<CharacterController2D>();
		animator = GetComponentInChildren<Animator>();

	}
	
	// Update is called once per frame
	void Update()
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * Setting.runSpeed;

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
		
		
		
	}

	void FixedUpdate()
	{
		// Move our character
	
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump,horizontalMove);
		jump = false;
		
		
		
	}
}
