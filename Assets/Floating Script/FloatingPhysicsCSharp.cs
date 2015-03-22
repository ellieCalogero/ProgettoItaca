
using UnityEngine;
using System.Collections;

public class FloatingPhysicsCSharp : MonoBehaviour {
    private float sine = 0.0f;
    private int sw = 0; //switch needed during sine curve
    private float timer = 0.0f;
    private float xMovement;
    
    public float verticalSpeed = 1.0f;
    public float verticalDistance = 1.0f;
    public float horizontalSpeed = 1.0f;
    


	void Start () 
	{		//Only executes when the program starts
		xMovement = Random.Range (-.5f, .5f) * horizontalSpeed;   //random value between -0.5 and 0.5, causing some movement on the x axis.
	}
	void FixedUpdate () {   //FixedUpdate is used because it is used with physics

	    if(sine < Mathf.PI && sw == 0)
		{	//sine variable is fluctuating between 0 and Pi causing an up and down motion simulating floating, think sine curve
	        sine += Time.deltaTime;
	    }
	    if(sine >= Mathf.PI){
		    sw = 1;
	   	}
	    if(sine <= 0){
		    sw = 0;
		}
	    if(sine >= 0 && sw == 1){
	        sine = 0;
	    }	
		
	    rigidbody.velocity = new Vector3(xMovement, Mathf.Sin(2*sine*verticalSpeed)*verticalDistance, 0);	//Adds the x axis movement and up and down motion to the object
	
	    if(timer < 10){ //increments timer
		    timer += Time.deltaTime;
	    }
	}
}