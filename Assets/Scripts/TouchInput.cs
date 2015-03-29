using UnityEngine;
using System.Collections;

public class TouchInput : MonoBehaviour {



	void Start () 
	{
	

	}
	

	void Update () 
	{

	}

	public void ChangeLevel() 
	
	{
		Application.LoadLevel ("PrototipoBarchetta");
	}

	public void QuitApplication ()
	
	{
		Application.Quit();
	}
}
