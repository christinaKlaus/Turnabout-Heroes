﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerCollision : MonoBehaviour {
	
	// Script, das das Ende des Spiels (Kollision des Spielers mit einem Hindernis) triggert
	public UnityEvent playerHit;
	[SerializeField] GameObject gameOverUI;

	void Start(){
		playerHit = new UnityEvent();
		playerHit.AddListener(ShowEndscreen);
	}

	void OnTriggerEnter(Collider coll){
		playerHit.Invoke();
	}

	void ShowEndscreen(){
		Time.timeScale = 0;
		gameOverUI.SetActive(true);
		GameManager.instance.gameIsRunning = false;
	}
}
