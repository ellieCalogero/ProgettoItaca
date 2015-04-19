using UnityEngine;
using System.Collections;

public class Bronzo : MonoBehaviour {

	private Animator anim;
	private GameObject Player;

	public int count=0;
	float spawnTimer;


	void Start () {

		Player = GameObject.FindGameObjectWithTag("Player");
		//Player.GetComponent<Score> ().ScoreCounter ();

		spawnTimer = 1.0f;
		PlayerPrefs.SetInt("CurrentScore", 0); // azzeriamo il contatore
	}

	void Awake () 
	{
		anim = GetComponent<Animator> ();
	}

	


	void AddScore()
	{
		// prende il punteggio attuale
		int _tempScore = PlayerPrefs.GetInt("CurrentScore");
		
		// aggiungiamo 10 punti e salviamo il nuovo risultato
		_tempScore += 100;
		PlayerPrefs.SetInt("CurrentScore", _tempScore);
	}

	public void OnTriggerEnter(Collider otherCollider)
	{
		if(otherCollider.gameObject.tag.Equals("Player"))
		{
			//Parte l'animazione del doblone che salta
			anim.SetBool ("Doblone", true);
			//L'oggetto viene distrutto dopo 1 secondo
			StartCoroutine (WaitForAnimation ());

			//Player.GetComponent<Score>().score++;
			AddScore(); 
			Debug.Log(Player.GetComponent<Score>().score);
			//Destroy(this.gameObject);
		}
		
	}

	IEnumerator WaitForAnimation()
	{
		yield return new WaitForSeconds(1);
		Destroy (gameObject);
	}
}
