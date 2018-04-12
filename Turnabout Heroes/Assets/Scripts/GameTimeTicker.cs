using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameTimeTicker : MonoBehaviour {
	
	public static float gameTimer;
	[SerializeField] UnityEngine.UI.Text scoreUIText;

	void Start(){
		StartCoroutine("Tick");
		GameManager.timerReset.AddListener(ResetGameTimer);
	}
	public void ResetGameTimer(){
		gameTimer = 0;
	}

	IEnumerator Tick(){
		while(GameManager.instance.gameIsRunning){
			gameTimer += Time.deltaTime;
			UpdateScore();
			yield return new WaitForEndOfFrame();
		}
	}

	void UpdateScore(){
		GameManager.instance.currentScore = gameTimer;
		scoreUIText.text = string.Format("{0:#0.0} s", GameManager.instance.currentScore);
	}
}
