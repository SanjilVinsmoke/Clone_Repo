using UnityEngine;
public class SimpleBullet : Bullets
{
	private bool hasHitGround;
	protected override void Awake()
	{
		base.Awake();
		rb.gravityScale = 0.0f;
		rb.velocity = transform.right * soBullet.speedOfBullet;
	}

	protected override void Update()
	{
		base.Update();
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (!hasHitGround)
		{
			Collider2D damageHit = Physics2D.OverlapCircle(soBullet.damagePosition.position, soBullet.damageRadius,soBullet.whatIsPlayer);
			Collider2D groundHit = Physics2D.OverlapCircle(soBullet.damagePosition.position, soBullet.damageRadius, soBullet.whatIsGround);

			if (damageHit)
			{
				damageHit.transform.SendMessage("Damage", attackDetails);
				Destroy(gameObject);
			}

		}


	}
}
