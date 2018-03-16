using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullets : MonoBehaviour {
	public ParticleSystem explosion;
	public Image healthBar;
	public float startHealth = 100;
	private float health;
	int hit=10;
	int scoreValue=10;
	public AudioSource sounds;
	// Use this for initialization
	void Start () {
		health = startHealth;
		sounds = GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator OnParticleCollision (GameObject other){
		health -= hit;	
		healthBar.fillAmount = health / startHealth;
		if (health <= 0) {
			forScoring.score += scoreValue;
			Debug.Log ("PArticle Hit");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (0.3f);
			Destroy (gameObject);
		}
	}
}	
