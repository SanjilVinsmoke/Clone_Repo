using System;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   public Transform shootPoint;
   public GameObject bullet;
   public Animator animator;
    [SerializeField] float timeBetweenShoot = 0.15f;
    float elpseTime = 0;
    [SerializeField] bool brust = true;
   private void Awake()
   {
      
   }
   private void Update()
   {
        if (brust)
        {
            if (Input.GetButton("Fire1"))
            {
                if (elpseTime <= 0)
                {

                    Shoot();
                    elpseTime = timeBetweenShoot;
                }
                else
                {
                    elpseTime -= Time.deltaTime;
                }
            }
        }
      
            else
            {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();

            }



        }
   }
   void Shoot()
   {
      animator.SetTrigger(Setting.isShooting);
      Instantiate(bullet,shootPoint.position,shootPoint.rotation);
      
   }
   
}
