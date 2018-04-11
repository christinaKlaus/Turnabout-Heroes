using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameTimeTicker : MonoBehaviour {
	
	public static float gameTimer;
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
			yield return new WaitForEndOfFrame();
		}
	}
}
