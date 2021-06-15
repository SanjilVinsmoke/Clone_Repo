

	using Enemy.States.Data;
	public class PlayerDetectedState:State
	{
		protected D_PlayerDetectedState stateData;
		protected bool isPlayerDetectedMinAgroRange;
		protected bool isPlayerDetectedMaxAgroRange;

		
		public PlayerDetectedState(Entity entity, FiniteStateMachine stateMachine, int animBoolName ,D_PlayerDetectedState stateData) : base(entity, stateMachine, animBoolName)
		{
			this.stateData = stateData;
		}
		
		public override void Enter()
		{
			base.Enter();
			entity.SetVelocity(0f);
			isPlayerDetectedMinAgroRange=entity.CheckPlayerInMinAgroRange();
			isPlayerDetectedMaxAgroRange = entity.CheckPlayerInMaxAgroRange();
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
			isPlayerDetectedMinAgroRange=entity.CheckPlayerInMinAgroRange();
			isPlayerDetectedMaxAgroRange = entity.CheckPlayerInMaxAgroRange();
		}
	}

