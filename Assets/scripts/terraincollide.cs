using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class terraincollide : MonoBehaviour {
	public ParticleSystem explosion;
	public AudioSource sounds;

	Rigidbody rg;
	int x=0;

	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody> ();
		sounds = GetComponent<AudioSource> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "enemy") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}	
			if (col.gameObject.name == "Cube") {
				print ("Helle");
				explosion.Play ();
				sounds.Play ();
				yield return new WaitForSeconds (1f);
				Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);
				


			}
			if (col.gameObject.name == "Cube4") {
				print ("Hell0");
				explosion.Play ();
				sounds.Play ();
				yield return new WaitForSeconds (1f);
				Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);
				
		
			}
			if (col.gameObject.name == "Cube2") {
				print ("Helle");
				explosion.Play ();
				sounds.Play ();
				yield return new WaitForSeconds (1f);
				Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);

		
			}
		if (col.gameObject.name == "obstacle1") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
		if (col.gameObject.name == "obstacle2") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
		if (col.gameObject.name == "obstacle3") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
		if (col.gameObject.name == "obstacle4") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
		if (col.gameObject.name == "obstacle5") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
		if (col.gameObject.name == "obstacle6") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);

		}
		if (col.gameObject.name == "obstacle7") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
		if (col.gameObject.name == "obstacle8") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
		if (col.gameObject.name == "obstacle9") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
		if (col.gameObject.name == "StatueBear") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
		if (col.gameObject.name == "StatueBear2") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
		if (col.gameObject.name == "StatueBear3") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
			if (col.gameObject.name == "Cube3") {
				print ("Helle");
				explosion.Play ();
				sounds.Play ();
				yield return new WaitForSeconds (1f);
				Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);
				
			}	
			if (col.gameObject.name == "Terrain") {
				print ("Helle");
				explosion.Play ();
				sounds.Play ();
				yield return new WaitForSeconds (1f);
				Destroy (gameObject);
				Application.LoadLevel (Application.loadedLevel);
		
		
			}
		if (col.gameObject.tag == "enemy") {
			print ("Helle");
			explosion.Play ();
			sounds.Play ();
			yield return new WaitForSeconds (1f);
			Destroy (gameObject);
			Application.LoadLevel (Application.loadedLevel);


		}
		

}
	void LoadGameScene(){
		SceneManager.LoadScene (Application.loadedLevel);
	}
}
