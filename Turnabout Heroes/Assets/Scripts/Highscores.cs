using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName="Data Sets/Highscores")]
public class Highscores : ScriptableObject {

	//Scriptable Object, das zum Speichern der Highscores verwendet wird, welche in Form der Wrapper-Klasse PlayerInfo hinterlegt werden

	public List<PlayerInfo> playerScores;

	/*override public string ToString(){
		string s = "";
		foreach (PlayerInfo i in playerScores){
			s += i.name + ": " + i.highscore + "s; ";
		}
		return s;
	}*/

}

[Serializable]
public class PlayerInfo {
	public string name;
	public float highscore;
}
