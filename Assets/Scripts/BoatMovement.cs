using UnityEngine;
using System.Collections;

public class BoatMovement : MonoBehaviour 
{
	public float lateralSpeed;
	public float forwardSpeed;
	private float currentSpeed;

	public GameObject respawnPoint;
	public GameObject scoreObj;

	// prova inclinazione//
	public float MaxTiltAngle = 20.0f;
	public float tiltSpeed = 30.0f; // tilting speed in degrees/second
	Vector3 curRot;
	float maxY;
	float minY;


	void Start () 
	{
		// Get initial rotation
		curRot = this.transform.eulerAngles;
		// calculate limit angles:
		maxY = curRot.y + MaxTiltAngle;
		minY = curRot.y - MaxTiltAngle;

		currentSpeed = forwardSpeed;
	}
	// // // // // // // // // // // // // // //

	void Update () 
	{
		//Accelerazione e decellerazione su asse Z
		if(Input.GetKey(KeyCode.DownArrow) && currentSpeed>50)
		{
			currentSpeed -= (forwardSpeed/2)*Time.deltaTime;  
		}

		else if(Input.GetKey(KeyCode.UpArrow) && currentSpeed<forwardSpeed)
		{
			float incr = (forwardSpeed/2)*Time.deltaTime;

			if(currentSpeed+incr <= forwardSpeed)
			{
				currentSpeed += incr;
			}
			else
			{
				currentSpeed = forwardSpeed;
			}
		}


		//prova inclinazione//

		// "rotate" the angles mathematically:
		curRot.y += Input.GetAxis("Horizontal") * Time.deltaTime * tiltSpeed;                
		// Restrict rotation along x and z axes to the limit angles:
		curRot.y = Mathf.Clamp (curRot.y, minY, maxY);
		
		// Set the object rotation
		this.transform.eulerAngles = curRot;
		// 	// // // // // // // // // // // // // // //

		//movimento continuo della barca in avanti
		transform.Translate (Vector3.forward * forwardSpeed * Time.deltaTime);

		// accelerometro con velocità
		Vector3 force = new Vector3 (Input.acceleration.x, 0, 0);
		transform.Translate (force*lateralSpeed*Time.deltaTime);


		//movimento per pc
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate (Vector3.left * lateralSpeed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate (Vector3.right * lateralSpeed * Time.deltaTime);
		}
			Debug.Log (curRot);
		}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "obstacle")
		{
			curRot = new Vector3 (0.0f,0.0f,0.0f);
			Respawn();
		}
	}

	void Respawn ()
	{
		transform.position = respawnPoint.transform.position;
	}
}
