using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseInput : MonoBehaviour {

	public CanvasGroup canvasGroup;

	void Start ()
	{

	}

	public void PauseButton ()
	{
		canvasGroup.alpha = 1;
		canvasGroup.interactable = false;
		canvasGroup.blocksRaycasts = false;


		//Time.timeScale = 0;

	}

	public void ResumeGame ()
	{
		canvasGroup.alpha = 0;
		canvasGroup.interactable = true;
		canvasGroup.blocksRaycasts = true;
		//Time.timeScale = 1;
	}

	public void Options ()
	{

	}

	public void MainMenu ()
	{
		Application.LoadLevel ("MainMenu");
	}
}
