using Enemy.States.Data;
using UnityEngine;


public class E1_PlayerDetectedState : PlayerDetectedState
{
	private Enemy1 enemy;
	private D_PlayerDetectedState playerDetectedStateData;


	public E1_PlayerDetectedState(Entity entity, FiniteStateMachine stateMachine, int animBoolName,D_PlayerDetectedState stateData, Enemy1 enemy) : base(entity, stateMachine, animBoolName, stateData)
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
		if (!isPlayerDetectedMaxAgroRange)
		{
			enemy.idleState.SetFlipAfterIdle(false);
			stateMachine.ChangeState(enemy.idleState);
		}
	}

	public override void PhysicUpdate()
	{
		base.PhysicUpdate();
	}
}
