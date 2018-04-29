using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName="Data Sets/Highscores")]
public class Highscores : ScriptableObject {

	//Scriptable Object, das zum Speichern der Highscores verwendet wird, welche in Form der Wrapper-Klasse PlayerInfo hinterlegt werden

	public List<PlayerInfo> playerScores;

}

[Serializable]
public class PlayerInfo {
	public string name;
	public float highscore;
}
