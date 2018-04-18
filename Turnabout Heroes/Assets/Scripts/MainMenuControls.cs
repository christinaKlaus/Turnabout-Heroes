using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour {

	//händelt Buttons im Hauptmenü
	[SerializeField] Canvas highscoresCanvas;

	void Start(){
		highscoresCanvas.gameObject.SetActive(false);
	}

	public void StartNewGame(){
		SceneManager.LoadScene(1);
	}

	public void Exit(){
		Application.Quit();
	}
}
