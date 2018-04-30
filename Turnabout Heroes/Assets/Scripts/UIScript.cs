using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

	//Kontrollscript für alle UI Objekte
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
		SceneManager.LoadScene(1);
		SaveToPlayerPrefs();
	}

	public void ReturnToMenu(){
		SaveToPlayerPrefs();
		SceneManager.LoadScene(0);
	}

	//liest Highscores aus ScriptableObject und trägt sie in angezeigte Liste ein
	void FillInHighscores(){
		for(int i = 0; i < scoreFields.Length; i++){
			scoreFields[i].transform.GetChild(0).GetComponent<Text>().text = highscoreData.playerScores[i].name;
			scoreFields[i].transform.GetChild(1).GetComponent<Text>().text = string.Format("{0:#0.0} s", highscoreData.playerScores[i].highscore);
		}
	}

	void DisplayCurrentScore(){
		currentScoreText.text = string.Format("{0:#0.0} s", GameManager.instance.currentScore);
	}

	//Überprüfung, ob ein neuer Highscore erzielt wurde
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

	// schreibt neuen Highscore in ScriptableObject, sollte ein Name eingegeben werden
	public void SetNewHighscore(){
		
		for(int i = highscoreData.playerScores.Count-1; i > newHighscoreIndex; i--){
			highscoreData.playerScores[i] = highscoreData.playerScores[i-1];
		}

		PlayerInfo info = new PlayerInfo();
		info.highscore = GameManager.instance.currentScore;
		//highscoreData.playerScores[newHighscoreIndex].highscore = GameManager.instance.currentScore;
		
		if(newHighscorePlayerName.text != "") info.name = newHighscorePlayerName.text; //highscoreData.playerScores[newHighscoreIndex].name = newHighscorePlayerName.text;
			else info.name = "info"; //highscoreData.playerScores[newHighscoreIndex].name = "Player";
		
		highscoreData.playerScores[newHighscoreIndex] = info;

		//geänderte Daten persistent in den PlayerPrefs speichern
		SaveToPlayerPrefs();
		FillInHighscores();
	}

	//speichert die Highscores persistent in den PlayerPrefs
	public void SaveToPlayerPrefs(){
		string json = JsonUtility.ToJson(highscoreData);
		PlayerPrefs.SetString("highscores", json);
	}

	public void LoadFromPlayerPrefs(){
		if(PlayerPrefs.HasKey("highscores")){
			string json = PlayerPrefs.GetString("highscores");
			JsonUtility.FromJsonOverwrite(json, highscoreData);
		}
	}
}
