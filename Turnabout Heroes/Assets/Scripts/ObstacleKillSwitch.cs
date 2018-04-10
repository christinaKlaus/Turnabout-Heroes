using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleKillSwitch : MonoBehaviour {
	public UnityEvent obstacleDestroyed;
	void OnTriggerEnter(Collider coll){
		Destroy(coll.gameObject);
		obstacleDestroyed.Invoke();
	}
}
