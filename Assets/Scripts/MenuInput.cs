using UnityEngine;
using System.Collections;

public class MenuInput : MonoBehaviour {


	public void ChangeLevel() 
	
	{
		Application.LoadLevel ("PrototipoBarchetta");
	}

	public void QuitApplication ()
	
	{
		Application.Quit();
	}
}
