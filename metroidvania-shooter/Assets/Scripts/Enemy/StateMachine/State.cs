


	using System;
	using UnityEngine;
	public class State
	{
		protected FiniteStateMachine stateMachine;
		protected Entity entity;

		protected float startTime;
		
		protected int animBoolName;

		public State(Entity entity, FiniteStateMachine stateMachine,int animBoolName)
		{
			this.entity = entity;
			this.stateMachine = stateMachine;
			this.animBoolName = animBoolName;
		}
		public virtual void Enter()
		{
			DoChecks();
			startTime = Time.time;
			entity.animator.SetBool(animBoolName,true);
		}
		public virtual void Exit()
		{
			entity.animator.SetBool(animBoolName,false);
		}
		public virtual void LogicUpdate()
		{
			
		}
		public virtual void PhysicUpdate()
		{
			DoChecks();
		}
		public virtual void DoChecks()
		{
			
		}
	}
