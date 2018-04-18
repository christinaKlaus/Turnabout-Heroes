using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu(menuName="GameManager")]
public class GameManager : ScriptableObject {

	//Singleton, der den Spielzustand und aktuellen Score hält
	[HideInInspector] public bool gameIsRunning = true;
	public float currentScore;
	public static UnityEvent timerReset;
	private static GameManager _instance;
	
	public static GameManager instance { get {
			if(!_instance)
				_instance = CreateInstance<GameManager>();
			
			return _instance;
		}
	}
	
	void Awake(){
		GameManager.timerReset = new UnityEvent();
	}

	
}
