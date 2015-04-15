using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Manager : MonoBehaviour {

	// Use this for initialization

	private Animator menuAnim;
	bool menuOn = false;

	//Button b= GetComponent<>;

	void Awake () 
	{
		menuAnim = GetComponent<Animator> ();
	}

	void Update ()
	{
//		b.onClick.AddListener(()=>
//		{
//			BeginMenu ();
//		});
	}

	public void BeginMenu ()
	{
		Debug.Log ("TASTO PREMUTO");
		if (!menuOn)
		{
			menuAnim.SetTrigger ("FadeIn");
			menuOn=true;
			//Time.timeScale=0;
		}


		else
		{
			menuAnim.SetTrigger ("FadeOut");
			menuOn=false;
			//Time.timeScale=1;
		}
	}

}
