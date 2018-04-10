using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Pools/Obstacle Pool")]
public class ObstaclePool : ScriptableObject {
	public GameObject[] pool;
	
	public GameObject CreateNewRandom(Transform origin){		
		int rand = Random.Range(0, pool.Length);
		GameObject o = Instantiate(pool[rand], origin.position, Quaternion.identity, origin);
		return o;
	}
}
