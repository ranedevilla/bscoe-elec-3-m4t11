using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Splash2 : MonoBehaviour {

	public RawImage proj;
	public string loadLevel;

	void awake(){
		DontDestroyOnLoad (gameObject);
	}

	// Use this for initialization
	IEnumerator Start () {
		proj.canvasRenderer.SetAlpha (0.0f);
		//proj.canvasRenderer.SetAlpha (0.0f);
		yield return new WaitForSeconds (5.0f);
		fadeIn ();
		yield return new WaitForSeconds (2.5f);

		/*fadeOut ();
		yield return new WaitForSeconds (2.5f);*/
		/*	fadeIn1 ();
		yield return new WaitForSeconds (2.5f);
		fadeOut2 ();
		yield return new WaitForSeconds (2.5f);
		*/
	}

	// Update is called once per frame
	void Update () {
		enterGame ();

	}
	void fadeIn(){
		proj.CrossFadeAlpha (1.0f,1.5f,false);
	}
	/*void fadeOut(){
		proj.CrossFadeAlpha (0.0f,2.5f,false);
	}*/
	/*	void fadeIn1(){
		proj.CrossFadeAlpha (1.0f,1.5f,false);
	}
	void fadeOut2(){
		proj.CrossFadeAlpha (0.0f,2.5f,false);

	}*/
void enterGame(){
	if (Input.GetKey(KeyCode.S)) {
			print ("Hello");
		Invoke("LoadGameScene", 0.5f);
	}

}


	void LoadGameScene(){
	SceneManager.LoadScene (1);
}
}