

	using UnityEngine;
	public class RangedAttack:AttackState
	{
		protected D_RangedAttackState stateData;
		protected GameObject bullets;
		protected Bullets bulletScript;

		public RangedAttack(Entity entity, FiniteStateMachine stateMachine, int animBoolName, Transform attackPosition,D_RangedAttackState stateData) : base(entity, stateMachine, animBoolName, attackPosition)
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
		}

		public override void DoChecks()
		{
			base.DoChecks();
		}

		public override void TriggerAttack()
		{
			base.TriggerAttack();
		}

		public override void FinishAttack()
		{
			base.FinishAttack();
			bullets = GameObject.Instantiate(stateData.bullets, attackPosition.position, attackPosition.rotation);
			bulletScript = bullets.GetComponent<Bullets>();
			bulletScript.FireProjectile(stateData.projectileSpeed,stateData.projectileDamage);
		}
	}
	
