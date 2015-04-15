using UnityEngine;
using System.Collections;
//chiedere come far diventare la posizione del respawn uguale alla posizione del checkpoint.
public class checkpoint : MonoBehaviour 
{
	public Transform Check;
	public Transform RespawnPoint;

	void OnTriggerEnter (Collider coll)
	{
		if (coll.tag == "Player")
		{
			RespawnPoint.transform.position = Check.position;
		}
	}
}
