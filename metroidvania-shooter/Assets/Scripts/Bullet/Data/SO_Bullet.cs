using UnityEngine;


[CreateAssetMenu(fileName = "Bullet", menuName = "ScriptableObjects/Bullet/So_Bullet", order = 0)]
public class SO_Bullet : ScriptableObject
{
	public string bulletName;
	public int damage;
	public float speedOfBullet;
	public float damageRadius;
	public Transform damagePosition;
	public LayerMask whatIsPlayer;
	public LayerMask whatIsGround;
}
