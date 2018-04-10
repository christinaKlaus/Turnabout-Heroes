using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour {
	public float obstacleFallspeed;
	void Move(){
		transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - obstacleFallspeed);
	}

	void Update(){
		Move();
	}
	
}
