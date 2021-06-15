using System;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   public Transform shootPoint;
   public GameObject bullet;
   public Animator animator;

   private void Awake()
   {
      
   }
   private void Update()
   {
      if (Input.GetButtonDown("Fire1"))
      {
         Shoot();
      }
      
   }
   void Shoot()
   {
      animator.SetTrigger(Setting.isShooting);
      Instantiate(bullet,shootPoint.position,shootPoint.rotation);
      
   }
   
}
