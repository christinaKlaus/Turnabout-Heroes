using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

	[SerializeField] Highscores highscoreData;
	[SerializeField] RectTransform[] scoreFields;

	void OnEnable(){
		FillInHighscores();
	}

	public void PlayAgain(){
		Time.timeScale = 1f;
		GameManager.timerReset.Invoke();
		GameManager.instance.gameIsRunning = true;
		SceneManager.LoadScene(0);
	}

	public void ExitGame(){
		Debug.Log("Exit");
		Application.Quit();
	}

	public void FillInHighscores(){
		for(int i = 0; i < scoreFields.Length; i++){
			scoreFields[i].transform.GetChild(0).GetComponent<Text>().text = highscoreData.playerScores[i].name;
			scoreFields[i].transform.GetChild(1).GetComponent<Text>().text = "" + highscoreData.playerScores[i].highscore;
		}
	}
}
