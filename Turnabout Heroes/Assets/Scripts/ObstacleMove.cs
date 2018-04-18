using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour {
	//Bewegungsscript für die Hindernisse
	public float obstacleFallspeed;
	void Move(){
		transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - obstacleFallspeed * Time.timeScale);
	}

	void Update(){
		Move();
	}
	
}
