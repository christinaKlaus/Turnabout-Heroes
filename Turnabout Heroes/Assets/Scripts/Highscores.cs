using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName="Data Sets/Highscores")]
public class Highscores : ScriptableObject {

	//Scriptable Object, das zum Speichern der Highscores verwendet wird, welche in Form der inneren Wrapper-Klasse PlayerInfo hinterlegt werden

	[Serializable]
	public class PlayerInfo {
		public string name;
		public float highscore;
	}

	public List<PlayerInfo> playerScores;

	public void SaveToJson(){
		JsonUtility.ToJson(this);
	}

}
