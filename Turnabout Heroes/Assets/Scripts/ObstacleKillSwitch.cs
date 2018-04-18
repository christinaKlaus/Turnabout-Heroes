using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleKillSwitch : MonoBehaviour {
	//sorgt für die Zerstörung der Hindernisse, sobald sie den Bildschirm verlassen und sich in das Kill-Volume bewegen
	void OnTriggerEnter(Collider coll){
		Destroy(coll.transform.parent.gameObject);
	}
}
