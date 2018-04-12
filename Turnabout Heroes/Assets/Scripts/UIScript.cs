using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

	[SerializeField] Text currentScoreText;
	[SerializeField] GameObject ingameUIScore;
	[SerializeField] GameObject newHighscoreCanvas;
	[SerializeField] Text newHighscorePlayerName;
	[SerializeField] Highscores highscoreData;
	[SerializeField] RectTransform[] scoreFields;

	int newHighscoreIndex;
	
	
	void OnEnable(){
		ingameUIScore.gameObject.SetActive(false);
		FillInHighscores();
		DisplayCurrentScore();
		CheckForNewHighscore();
	}

	public void PlayAgain(){
		Time.timeScale = 1f;
		GameManager.instance.currentScore = 0;
		GameManager.timerReset.Invoke();
		GameManager.instance.gameIsRunning = true;
		SceneManager.LoadScene(0);
	}

	public void ExitGame(){
		Debug.Log("Exit");
		Application.Quit();
	}

	void FillInHighscores(){
		for(int i = 0; i < scoreFields.Length; i++){
			scoreFields[i].transform.GetChild(0).GetComponent<Text>().text = highscoreData.playerScores[i].name;
			scoreFields[i].transform.GetChild(1).GetComponent<Text>().text = string.Format("{0:#0.0} s", highscoreData.playerScores[i].highscore);
		}
	}

	void DisplayCurrentScore(){
		currentScoreText.text = string.Format("{0:#0.0} s", GameManager.instance.currentScore);
	}

	void CheckForNewHighscore(){
		for(int i = 0; i < highscoreData.playerScores.Count; i++){
			if(highscoreData.playerScores[i].highscore < GameManager.instance.currentScore){
				//new Highscore found
				newHighscoreIndex = i;
				newHighscoreCanvas.gameObject.SetActive(true);
				return;
			}
		}
	}

	public void CloseNewHighscoreCanvas(){
		newHighscoreCanvas.gameObject.SetActive(false);
	}

	public void SetNewHighscore(){
		highscoreData.playerScores[newHighscoreIndex].highscore = GameManager.instance.currentScore;
		
		if(newHighscorePlayerName.text != "") highscoreData.playerScores[newHighscoreIndex].name = newHighscorePlayerName.text;
			else highscoreData.playerScores[newHighscoreIndex].name = "Player";
		
		FillInHighscores();
		CloseNewHighscoreCanvas();
	}
}
