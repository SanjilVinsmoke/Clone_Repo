

	
	using UnityEngine;
	public class PlayerDetectedState:State
	{
		protected D_PlayerDetectedState stateData;
		protected bool isPlayerDetectedMinAgroRange;
		protected bool isPlayerDetectedMaxAgroRange;
		protected bool performLongRangeAction;
		protected bool performCloseRangeAction;
		protected bool isDetectingLedge;
		
		
		public PlayerDetectedState(Entity entity, FiniteStateMachine stateMachine, int animBoolName ,D_PlayerDetectedState stateData) : base(entity, stateMachine, animBoolName)
		{
			this.stateData = stateData;
		}
		
		public override void DoChecks()
		{
			base.DoChecks();

			isPlayerDetectedMinAgroRange = entity.CheckPlayerInMinAgroRange();
			isPlayerDetectedMinAgroRange = entity.CheckPlayerInMaxAgroRange();
			isDetectingLedge = entity.CheckLedge();
			performCloseRangeAction = entity.CheckPlayerInCloseRangeAction();
		}

		public override void Enter()
		{
			base.Enter();

			performLongRangeAction = false;
			entity.SetVelocity(0f);     
		}

		public override void Exit()
		{
			base.Exit();
		}

		public override void LogicUpdate()
		{
			base.LogicUpdate();

			if (Time.time >= startTime + stateData.longRangeActionTime)
			{
				performLongRangeAction = true;
			}
		}

		
	}

