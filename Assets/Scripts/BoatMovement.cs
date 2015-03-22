using UnityEngine;
using System.Collections;

public class BoatMovement : MonoBehaviour {
	
	
	public float lateralSpeed;
	public float forwardSpeed;

	public GameObject respawnPoint;


	// Use this for initialization
	void Start () {
	
	}

	void Update () {

		//movimento continuo della barca verso avanti
		transform.Translate (Vector3.forward * forwardSpeed * Time.deltaTime);

		//accelerometro con velocità
//		Vector3 force = new Vector3 (Input.acceleration.x, 0, 0);
//		transform.Translate (force*lateralSpeed*Time.deltaTime);


		//movimento per pc
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(Vector3.left*lateralSpeed*Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(Vector3.right*lateralSpeed*Time.deltaTime);
		}


	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "obstacle")
		{
			Respawn();
		}
	}

	void Respawn ()
	{
		transform.position = respawnPoint.transform.position;
	}
}
