using System;
using UnityEngine;
using Random = UnityEngine.Random;
public class Entity: MonoBehaviour
 {
	 public D_Entity entityData;
		public Rigidbody2D rb { get; private set; }
		public Animator animator { get; private set; }
		public GameObject aliveGo { get; private set; }
		
		
		public int FacingDirection { get; private set; }
		public int lastDamageDirection { get; private set; }
		public AnimationToStateMachine atsm { get; private set; }
		public FiniteStateMachine stateMachine;
		
		private Vector2 velocityWorkSpace;
		private float currentHealth;
		private float lastDamageTime;
	 
		protected bool isDead;

		[SerializeField]
		private Transform wallCheck;
		[SerializeField]
		private Transform ledgeCheck;
		[SerializeField]
		protected Transform playerCheck;
		
		public virtual void Start()
		{
			FacingDirection = 1;
			currentHealth = entityData.maxHealth;
			aliveGo = transform.Find("Alive").gameObject;
			rb = aliveGo.GetComponent<Rigidbody2D>();
			animator = aliveGo.GetComponent<Animator>();
			stateMachine = new FiniteStateMachine();
		}
		public virtual void Update()
		{
			stateMachine.currentState.LogicUpdate();
		}
		public virtual void FixedUpdate()
		{
			stateMachine.currentState.PhysicUpdate();
		}
		public virtual void SetVelocity(float velocity)
		{
			velocityWorkSpace.Set(FacingDirection*velocity,rb.velocity.y);
			rb.velocity = velocityWorkSpace;
		}
		public virtual bool CheckWall()
		{
			return Physics2D.Raycast(wallCheck.position, aliveGo.transform.right, entityData.wallCheckDistance, entityData.whatIsGround);
		}
		public virtual bool CheckLedge()
		{
			return Physics2D.Raycast(ledgeCheck.position, Vector2.down, entityData.ledgeCheckDistance, entityData.whatIsGround);

		}
		public virtual bool CheckPlayerInMinAgroRange()
		{
			return Physics2D.Raycast(playerCheck.position, aliveGo.transform.right, entityData.minAgroDistance, entityData.whatIsPlayer);
		}
		public virtual bool CheckPlayerInMaxAgroRange()
		{
			return Physics2D.Raycast(playerCheck.position, aliveGo.transform.right, entityData.maxAgroDistance, entityData.whatIsPlayer);
		}
		public virtual bool CheckPlayerInCloseRangeAction()
		{
			return Physics2D.Raycast(playerCheck.position, aliveGo.transform.right, entityData.closeRangeActionDistance, entityData.whatIsPlayer);
		}

		
		public virtual void Flip()
		{
			FacingDirection *= -1;
			aliveGo.transform.Rotate(0,180f,0);
		}
		
		public virtual void Damage(AttackDetails attackDetails)
		{
			lastDamageTime = Time.time;

			currentHealth -= attackDetails.damageAmount;
			Instantiate(entityData.hitParticle, aliveGo.transform.position, Quaternion.Euler(0f, 0f, Random.Range(0f, 360f)));

			if(attackDetails.position.x > aliveGo.transform.position.x)
			{
				lastDamageDirection = -1;
			}
			else
			{
				lastDamageDirection = 1;
			}
			
			if(currentHealth <= 0)
			{
				isDead = true;
			}
		}
		public virtual void OnDrawGizmos()
		{
			Gizmos.color = Color.blue;
			Gizmos.DrawLine(wallCheck.position,wallCheck.position+(Vector3)(Vector2.right*FacingDirection*entityData.wallCheckDistance));
			Gizmos.DrawLine(ledgeCheck.position, ledgeCheck.position + (Vector3) (Vector2.down *  entityData.ledgeCheckDistance));
			Gizmos.color=Color.red;
			Gizmos.DrawWireSphere(playerCheck.position + (Vector3)(Vector2.right * entityData.closeRangeActionDistance *FacingDirection), 0.2f);
			Gizmos.DrawWireSphere(playerCheck.position + (Vector3)(Vector2.right * entityData.minAgroDistance*FacingDirection), 0.2f);
			Gizmos.DrawWireSphere(playerCheck.position + (Vector3)(Vector2.right * entityData.maxAgroDistance*FacingDirection), 0.2f);
			
		}
 }
