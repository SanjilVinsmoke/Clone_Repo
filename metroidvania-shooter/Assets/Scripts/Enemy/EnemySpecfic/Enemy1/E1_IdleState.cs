using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1_IdleState : IdelState
{
	private Enemy1 enemy;
	
	private D_IdleState idleStateData;

	public E1_IdleState(Entity entity, FiniteStateMachine stateMachine, int animBoolName, D_IdleState stateData,Enemy1 enemy) : base(entity, stateMachine, animBoolName, stateData)
	{
		this.enemy = enemy;
	}

	public override void Enter()
	{
		base.Enter();
	}

	public override void Exit()
	{
		base.Exit();
	}

	public override void LogicUpdate()
	{
		base.LogicUpdate();
		if (isPlayerInMinAgroRange)
		{
			stateMachine.ChangeState(enemy.playerDetectedState);
		}
		else if (isIdleTimeOver)
		{
			stateMachine.ChangeState(enemy.moveState);
		}
	}

	public override void PhysicUpdate()
	{
		base.PhysicUpdate();
	}
}
