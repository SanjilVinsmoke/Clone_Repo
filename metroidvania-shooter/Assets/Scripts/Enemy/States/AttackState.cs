using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State
{
	protected D_AttackState stateData;

	
	
	public AttackState(Entity entity, FiniteStateMachine stateMachine, int animBoolName,D_AttackState stateData) : base(entity, stateMachine, animBoolName)
	{
		this.stateData = stateData;
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
		
	}

	public override void PhysicUpdate()
	{
		base.PhysicUpdate();
		Shoot();
	}
	public void Shoot()
	{
		//TODO:Spawning of Bullet
	
	}

	
	
}
