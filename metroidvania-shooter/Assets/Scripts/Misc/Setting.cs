using System;
using UnityEngine;

public static class Setting
 {
	 public static int isRunning;
	 public static int isShooting;
	 public static int speed;
	 public static float runSpeed = 20f;
	public static float climbSpeed = 2f;
	 public static int isCrouching;
	 public static int isJumping;	 
	 static Setting()
	 {
		 isRunning = Animator.StringToHash("isRunning");
		 isShooting = Animator.StringToHash("isShooting");
		 speed = Animator.StringToHash("speed");
		 isCrouching = Animator.StringToHash("isCrouching");
		 isJumping = Animator.StringToHash("isJumping");
	 }
 }

