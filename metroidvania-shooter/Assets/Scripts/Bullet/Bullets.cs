using System;
using UnityEngine;
public class Bullets : MonoBehaviour
{
	public SO_Bullet soBullet;
	public Rigidbody2D rb;
	public AttackDetails attackDetails;
	protected virtual void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	protected virtual void Update()
	{
		if (transform.position.x>40||transform.position.x< -40)
		{
			Destroy(gameObject);
		}
	}
	protected virtual void FixedUpdate()
	{
		if (transform.position.x>40||transform.position.x< -40)
		{
			Destroy(gameObject);
		}
	}
	public void FireProjectile(float speed, float damage)
	{
		soBullet.speedOfBullet = speed;
		attackDetails.damageAmount = damage;
	}


}

