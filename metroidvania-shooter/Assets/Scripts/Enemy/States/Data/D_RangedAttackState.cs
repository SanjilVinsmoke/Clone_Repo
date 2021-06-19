using UnityEngine;



	[CreateAssetMenu(fileName = "rangedAttackStateData", menuName = "Data/StateData/Attack/RangedAttack State")]	
	public class D_RangedAttackState : ScriptableObject
	{
		public GameObject bullets;
		public float projectileDamage = 10f;
		public float projectileSpeed = 12f;
		public float projectileTravelDistance;
	}

