using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseInput : MonoBehaviour {

	//private Animator menuAnim;
	//bool menuOn = false;


	void Start ()
	{

	}

	public void PauseButton ()
	{
		Debug.Log ("TASTO PREMUTO");
	}

	public void ResumeGame ()
	{

	}

	public void Options ()
	{

	}

	public void MainMenu ()
	{
		Application.LoadLevel ("MainMenu");
	}
}
