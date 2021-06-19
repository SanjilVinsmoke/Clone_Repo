using UnityEngine;
[CreateAssetMenu(fileName = "_LookPlayerData", menuName = "Data/StateData/LookForPlayer Data ", order = 0)]
public class D_LookForPlayer : ScriptableObject
{
	public int amountOfTurns = 2;
	public float timeBetweenTurns = 0.75f;
	public float longRangeActionTime =.2f;
}
