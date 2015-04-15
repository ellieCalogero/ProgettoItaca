using UnityEngine;
using System.Collections;

public class SpawnPoint : MonoBehaviour 
{
	public Transform RespawnPoint;

	public GameObject player;

	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Scoglioni")
		{
			player.transform.position = RespawnPoint.position;
		}
	}
}