using System.Collections; 
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "newIdleData", menuName = "Data/StateData/Idle Data ", order = 0)]
public class D_IdleState : ScriptableObject
{
  public float minIdleTime =1f;
  public float maxIdleTime =2f;
}
