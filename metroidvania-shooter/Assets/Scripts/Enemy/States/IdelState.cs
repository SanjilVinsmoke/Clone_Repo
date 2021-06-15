using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdelState : State
{

	protected D_IdleState stateData;
	protected bool flipAfterIdle;
	protected bool isIdleTimeOver;
	protected float idleTime;
	protected bool isPlayerInMinAgroRange;

	
	public IdelState(Entity entity, FiniteStateMachine stateMachine, int animBoolName,D_IdleState stateData) : base(entity, stateMachine, animBoolName)
	{
		this.stateData = stateData;
	}

	public override void Enter()
	{
		base.Enter();
		entity.SetVelocity(0f);
		isIdleTimeOver = false;
		SetRandomIdleTime();
		
	}

	public override void Exit()
	{
		base.Exit();
		if (flipAfterIdle)
		{
			entity.Flip();
		}
	}

	public override void LogicUpdate()
	{
		base.LogicUpdate();
		if (Time.time>=startTime+idleTime)
		{
			isIdleTimeOver = true;

		}
	}

	public override void PhysicUpdate()
	{
		base.PhysicUpdate();
	}
	public void SetFlipAfterIdle(bool flip)
	{
		flipAfterIdle = flip;
		isPlayerInMinAgroRange = entity.CheckPlayerInMinAgroRange();
	}
	public void SetRandomIdleTime()
	{
		idleTime = Random.Range(stateData.minIdleTime, stateData.maxIdleTime);
	}
}
