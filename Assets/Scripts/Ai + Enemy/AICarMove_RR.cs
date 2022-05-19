using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AICarMove_RR : MonoBehaviour
{
        #region Variable
        //Variables (pulic can be changed in unity / private can ONLY be changed in script)
	[SerializeField]
	GameObject targetAICar; //The car that is moving
	[SerializeField]
	GameObject[] targetNavMeshObjects; //An Array of the waypoints on the map it is going towards
	int targetNavMeshObjectCounts; //The number of waypoints
	int targetNavMeshObjectNow; //The number which the car is currently on
	Vector3 startPos; //The starting position
	Vector3 startRot; //The starting rotaion
	NavMeshAgent navMeshAgentCompornent; //The nav mesh component on the car
	public float CAR_SPEED_MAX = 1.0f; //The speed of the AI
        #endregion

        #region Methods
	void Start () //Runs at the first frame
	{
		navMeshAgentCompornent = this.GetComponent<UnityEngine.AI.NavMeshAgent>(); //Allows the script to use the nav mesh component
		startPos = targetNavMeshObjects[0].transform.localPosition; //Sets the start poition to the first waypoint' poition
		startRot = targetNavMeshObjects[0].transform.localEulerAngles; //Sets the start rotation to the first waypoint's rotaion
		targetNavMeshObjectCounts = targetNavMeshObjects.Length -1; //Goes down the list that is within the array
	}
	public void InitAICar () //Animations for the AI car
	{
		navMeshAgentCompornent.speed = 0.0f; //Sets the AI speed to 0
		targetAICar.GetComponent<Animation>().Play("00_Stop"); //Plays the stop animation on the wheels
		StartCoroutine(startCar(3.0f)); //Restarts the car
	}
	IEnumerator startCar (float startDelayTime) //The start of the car
	{
		navMeshAgentCompornent.speed = 0.0f; //Sets the AI speed to 0
		targetAICar.GetComponent<Animation>().Play("00_Stop"); //Plays the stop animation on the wheels
		yield return new WaitForSeconds(startDelayTime); //Waits for the coroutine delay

		targetNavMeshObjectNow = 1; //Sets the array to the next waypoint
		navMeshAgentCompornent.SetDestination(targetNavMeshObjects[targetNavMeshObjectNow].transform.localPosition); //Sets the nav mesh to this waypoint
		this.transform.localPosition = startPos; //This keeps the car centered on its position
		this.transform.localEulerAngles = startRot; //This keeps the car centered on its rotation

		yield return new WaitForSeconds(0.5f); //Waits for 0.5 Seconds
		navMeshAgentCompornent.speed = CAR_SPEED_MAX; //Sets the nav mesh speed to the scripts max speed
		targetAICar.GetComponent<Animation>().Play("01_Run"); //Plays the run animation on the wheels
	}
	void Update () //Runs every frame
	{
		if (navMeshAgentCompornent.remainingDistance < 0.1f) //Checks if the AI has made it to its destination if so...
		{
			targetNavMeshObjectNow ++; //Sets the array to the next waypoint
			if (targetNavMeshObjectNow <= targetNavMeshObjectCounts) //Checks if the AI current waypoint less or equal to the amount of waypoints if so...
			{
				navMeshAgentCompornent.SetDestination(targetNavMeshObjects[targetNavMeshObjectNow].transform.localPosition); //Sets the nav mesh to the next waypoint
			}
			else if (targetNavMeshObjectNow >  targetNavMeshObjectCounts) //if not...
			{
				targetNavMeshObjectNow = 1; //Resets the array to the first waypoint
				navMeshAgentCompornent.SetDestination(targetNavMeshObjects[targetNavMeshObjectNow].transform.localPosition); //Sets the nav mesh to the next waypoint
			}
		}
	}
        #endregion
}