using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="GameManager")]
public class GameManager : ScriptableObject {

	private static GameManager _instance;
	[HideInInspector] public int highscore;
	public static GameManager instance { get {
			if(!_instance)
				_instance = CreateInstance<GameManager>();
			
			return _instance;
		}
	}

}
