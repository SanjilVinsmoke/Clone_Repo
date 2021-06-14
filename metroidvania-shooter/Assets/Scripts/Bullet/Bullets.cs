using System;
using UnityEngine;
public class Bullets : MonoBehaviour
{
	public SO_Bullet soBullet;
	private Rigidbody2D rigidbody2D;

	private void Awake()
	{
		rigidbody2D = GetComponent<Rigidbody2D>();
	}
	private void Update()
	{
		rigidbody2D.velocity = transform.right * soBullet.speedOfBullet;
		if (transform.position.x>40||transform.position.x<-40)
		{
			Destroy(gameObject);
		}
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log(other.name);
		Destroy(gameObject);
	}
}

