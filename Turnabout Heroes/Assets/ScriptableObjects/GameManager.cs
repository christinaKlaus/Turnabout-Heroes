using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : ScriptableObject {

	private static GameManager _instance;
	public static GameManager instance { get {
			if(!_instance)
				_instance = CreateInstance<GameManager>();
			
			return _instance;
		}
	}

}
