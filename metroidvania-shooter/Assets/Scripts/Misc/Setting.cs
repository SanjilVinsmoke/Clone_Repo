using System;
using UnityEngine;

public static class Setting
 {
	 public static int isRunning;
	 public static int isShooting;
	 public static int speed;
	 public static float runSpeed = 30f;
	 public static int isCrouching;
	 public static int isJumping;
	 //Enemies
	 public static int move;
	 public static int idle;
	 public static int playerDetected;
	 public static int look;
	 public static int charge;
	 static Setting()
	 {
		 isRunning = Animator.StringToHash("isRunning");
		 isShooting = Animator.StringToHash("isShooting");
		 speed = Animator.StringToHash("speed");
		 isCrouching = Animator.StringToHash("isCrouching");
		 isJumping = Animator.StringToHash("isJumping");
		 
		 //Enemies
		 move = Animator.StringToHash("move");
		 idle=Animator.StringToHash("idle");
		 playerDetected = Animator.StringToHash("playerDetected");
		 look = Animator.StringToHash("look");
		 charge = Animator.StringToHash("charge");
	 }
 }

