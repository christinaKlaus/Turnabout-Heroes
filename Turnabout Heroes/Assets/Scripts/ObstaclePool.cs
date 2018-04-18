using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Pools/Obstacle Pool")]
public class ObstaclePool : ScriptableObject {
	
	//Pool mit den Vorlagen für Hindernisse mit der Möglichkeit, einer zufälligen Hindernisgenerierung
	public GameObject[] pool;
	int lastIndex;
	
	public GameObject CreateNewRandom(Transform origin){		
		int rand = Random.Range(0, pool.Length);
		
		while(rand == lastIndex)
			rand = Random.Range(0, pool.Length);
		
		lastIndex = rand;
		GameObject o = Instantiate(pool[rand], origin.position, Quaternion.identity, origin);
		return o;
	}
}
