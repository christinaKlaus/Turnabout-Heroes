﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControls : MonoBehaviour {

	//steuert Buttons im Hauptmenü
	[SerializeField] GameObject highscoresCanvas;
	[SerializeField] Highscores highscoreData;
	[SerializeField] RectTransform[] scoreFields;

	void Start(){
		highscoresCanvas.gameObject.SetActive(false);
	}

	public void StartNewGame(){
		SceneManager.LoadScene(1);
	}

	public void Exit(){
		Application.Quit();
	}

	public void ShowHighscores(){
		FillInHighscores();
		highscoresCanvas.gameObject.SetActive(true);
	}

	void FillInHighscores(){
		for(int i = 0; i < scoreFields.Length; i++){
			scoreFields[i].transform.GetChild(0).GetComponent<Text>().text = highscoreData.playerScores[i].name;
			scoreFields[i].transform.GetChild(1).GetComponent<Text>().text = string.Format("{0:#0.0} s", highscoreData.playerScores[i].highscore);
		}
	}
}
