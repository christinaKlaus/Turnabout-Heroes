using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIScript : MonoBehaviour {
	public void PlayAgain(){
		Debug.Log("newGame");
		SceneManager.LoadScene(0);
	}

	public void ExitGame(){
		Debug.Log("Exit");
		Application.Quit();
	}
}
