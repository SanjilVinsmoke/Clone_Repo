
using UnityEngine;


public class E1_PlayerDetectedState : PlayerDetectedState
{
	private Enemy1 enemy;
	
	

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
		
		if (performLongRangeAction)
		{            
			stateMachine.ChangeState(enemy.chargeState);
		}
		else if (!isPlayerDetectedMaxAgroRange)
		{
			stateMachine.ChangeState(enemy.lookForPlayerState);
		}
		
	}

	public override void PhysicUpdate()
	{
		base.PhysicUpdate();
		
		
	}

	public override void DoChecks()
	{
		base.DoChecks();
	}


}
