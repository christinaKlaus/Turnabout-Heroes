using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleSpawner : MonoBehaviour {

	public float obstacleFallSpeed;
	public float respawnTime;
	public GameObject testObject;
	[SerializeField] ObstaclePool obstaclePool;
	float timer;

	void Start(){
		timer = 0;
		SpawnObstacle();
	}

	void SpawnObstacle(){
		obstaclePool.CreateNewRandom(transform);
		timer = 0;
		//StartCoroutine("Move");
	}

	void Update(){
		timer += Time.deltaTime;
		if(timer >= respawnTime)
			SpawnObstacle();
	}
	
}
