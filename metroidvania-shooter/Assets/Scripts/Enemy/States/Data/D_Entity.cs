using UnityEngine;

[CreateAssetMenu(fileName = "_EntityData", menuName = "Data/EntityData/Base Data ", order = 0)]
public class D_Entity : ScriptableObject
{
	[Header("Obstacle Check")]
	public float ledgeCheckDistance=0.2f;
	public float wallCheckDistance =0.4f;
	public LayerMask whatIsGround;
	
	[Header("Player Check")]
	public float minAgroDistance =3f;
	public float maxAgroDistance=4f;
	public GameObject hitParticle;
	public float closeRangeActionDistance =1f;
	public float maxHealth =100f;
	public LayerMask whatIsPlayer;
}
