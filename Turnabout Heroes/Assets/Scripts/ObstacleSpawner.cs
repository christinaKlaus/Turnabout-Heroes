using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleSpawner : MonoBehaviour {

	public float obstacleFallSpeed;
	public GameObject testObject;
	[SerializeField] ObstaclePool obstaclePool;
	List<GameObject> spawnedObjectsList;

	void Start(){
		spawnedObjectsList = new List<GameObject>();
		SpawnObstacle();
	}

	void SpawnObstacle(){
		GameObject test = obstaclePool.CreateNewRandom(transform);
		spawnedObjectsList.Add(test);
		//StartCoroutine("Move");
	}

	void Update(){
		if(spawnedObjectsList.Count > 0){
			foreach(GameObject o in spawnedObjectsList){
				o.transform.position = new Vector3(o.transform.position.x, o.transform.position.y,Mathf.Lerp(o.transform.position.z, -30, obstacleFallSpeed * Time.deltaTime));
			}
		}
	}
	IEnumerator Move(){
		while(spawnedObjectsList.Count > 0){
			foreach(GameObject o in spawnedObjectsList){
				o.transform.position = new Vector3(o.transform.position.x, o.transform.position.y, o.transform.position.z - obstacleFallSpeed);
			}
			yield return new WaitForSeconds(0.1f);
		}
	}
}
