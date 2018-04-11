using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName="GameManager")]
public class GameManager : ScriptableObject {

	[HideInInspector] public bool gameIsRunning = true;
	public int currentScore;
	public int[] highscores;
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
