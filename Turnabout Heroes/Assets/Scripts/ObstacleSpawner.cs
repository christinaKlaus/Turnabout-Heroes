using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleSpawner : MonoBehaviour {

	//Script für Spawnpunkt der Hindernisse
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

	// alle x Sekunden wird ein neues zufälliges Hindernis generiert
	void Update(){
		timer += Time.deltaTime;
		if(timer >= respawnTime)
			SpawnObstacle();
	}
	
}
