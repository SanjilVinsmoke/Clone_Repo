using UnityEngine;


[CreateAssetMenu(fileName = "Bullet", menuName = "ScriptableObjects/Bullet/So_Bullet", order = 0)]
public class SO_Bullet : ScriptableObject
{
	public string bulletName;
	public short id;
	public SpriteRenderer spriteRenderer;
	public int damage;
	public int speedOfBullet;
	
}
