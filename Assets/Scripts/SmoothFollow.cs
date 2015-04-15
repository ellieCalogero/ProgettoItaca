using UnityEngine;
using System.Collections;

public class SmoothFollow : MonoBehaviour 
{
	public GameObject targetPosition;
	public GameObject targetView;
	public float cameraElasticity;

	void Start () 
	{
		//messa qui la inizializza
		transform.position = targetPosition.transform.position;
	}
	
	void Update () 
	{
		//Cancellata questa riga, la camera parte dalla sua posizione principale
		//per poi teletrasportarsi nella posizione assegnata da targetPosition
		//transform.position = targetPosition.transform.position;

		//transform.position = Vector3.Lerp (transform.position, targetPosition.transform.position, cameraElasticity);
	}

	void LateUpdate ()
	{
		transform.LookAt (targetView.transform);
		transform.position = Vector3.Lerp (transform.position, targetPosition.transform.position, cameraElasticity);
	}
}
