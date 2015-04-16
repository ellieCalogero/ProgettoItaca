using UnityEngine;
using System.Collections;

public class stellina : MonoBehaviour {

	private GameObject Player;
	public int count=0;
	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void OnTriggerEnter(Collider otherCollider)
	{
		if(otherCollider.gameObject.tag.Equals("Player"))
		{
			Player.GetComponent<Score>().score++;
			Debug.Log(Player.GetComponent<Score>().score);
			Destroy(this.gameObject);
		}
	}
}
