using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleKillSwitch : MonoBehaviour {
	void OnTriggerEnter(Collider coll){
		Destroy(coll.transform.parent.gameObject);
	}
}
