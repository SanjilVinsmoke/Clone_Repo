
using UnityEngine;


	public class ChargeState:State
	{
		protected D_ChargeState stateData;
		
		protected bool isPlayerDetectedMinAgroRange;
		protected bool isDetectingWall;
		protected bool isDetectingLedge;
		protected bool isChargeTimeOver;

		
		public ChargeState(Entity entity, FiniteStateMachine stateMachine, int animBoolName,D_ChargeState stateData) : base(entity, stateMachine, animBoolName)
		{
			this.stateData = stateData;
		}

		public override void Enter()
		{
			base.Enter();
			isChargeTimeOver = false;
			entity.SetVelocity(stateData.chargeSpeed);
		}

		public override void Exit()
		{
			base.Exit();
		}

		public override void LogicUpdate()
		{
			base.LogicUpdate();
			if(Time.time >= startTime + stateData.chargeTime)
			{
				isChargeTimeOver = true;
			}
		}

		public override void PhysicUpdate()
		{
			base.PhysicUpdate();
		}

		public override void DoChecks()
		{
			base.DoChecks();
			isPlayerDetectedMinAgroRange = entity.CheckPlayerInMinAgroRange();
			isDetectingLedge = entity.CheckLedge();
			isDetectingWall = entity.CheckWall();
		}
	}

