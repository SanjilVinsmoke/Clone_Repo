
using UnityEngine;

public class Enemy1 :Entity
{
    public E1_IdleState idleState { get; private set; }
    public E1_MoveState moveState{ get; private set; }
    public E1_PlayerDetectedState playerDetectedState { get; private set; }
    public E1_LookForPlayerState lookForPlayerState { get; private set; }
    
    public E1_ChargeState chargeState { get; private set; }

    [Header("Player State Data")]
    [SerializeField]
    private D_IdleState idleStateData;
    [SerializeField]
    private D_MoveState moveStateData;
    [SerializeField]
    private D_PlayerDetectedState playerDetectedStateData;
    [SerializeField]
    private D_ChargeState chargeStateData;
    [SerializeField]
    private D_LookForPlayer lookForPlayerData;

  
    public override void Start()
    {
        base.Start();
        
        moveState = new E1_MoveState(this, stateMachine, Setting.move, moveStateData,this);
        idleState = new E1_IdleState(this, stateMachine, Setting.idle, idleStateData, this);
        playerDetectedState = new E1_PlayerDetectedState(this, stateMachine,Setting.playerDetected, playerDetectedStateData, this);
        lookForPlayerState = new E1_LookForPlayerState(this, stateMachine, Setting.look, lookForPlayerData, this);
        chargeState = new E1_ChargeState(this, stateMachine, Setting.charge,chargeStateData, this);

        stateMachine.Initialize(moveState);
    }

    /*public override bool CheckPlayerInMinAgroRange()
    {
       
        

        //return Physics2D.OverlapCircle((Vector2) (playerCheck.position), entityData.minAgroDistance,entityData.whatIsPlayer);

    }

    public override bool CheckPlayerInMaxAgroRange()
    {
        
        //return Physics2D.OverlapCircle((Vector2) (playerCheck.position), entityData.maxAgroDistance, entityData.whatIsPlayer);
    }*/

    /*public override void OnDrawGizmos()
    {
        base.OnDrawGizmos();
        Gizmos.color=Color.grey;
        Gizmos.DrawWireSphere(playerCheck.position,entityData.maxAgroDistance);
    }*/
}
