using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour {
	
	//Steuerung der Spielfiguren
	public float rotationAmount = 0.5f;
	[SerializeField] GameObject red;
	[SerializeField] GameObject blue; 
	
	//<-------Distance change variables-------->
	//public float distanceAmount = 0.5f;
	//[SerializeField] float maxDistance = 4f;
	//[SerializeField] float minDistance = 1f;

    void Update(){

		//Manipulation der Rotation der Spielfiguren
		if(!GameManager.instance.gameIsRunning)
			return;
		
       	if(Input.GetButton("TurnLeft")){
			transform.Rotate(new Vector3(0, -rotationAmount, 0));
	   	}

	   	if(Input.GetButton("TurnRight")){
			transform.Rotate(new Vector3(0, rotationAmount, 0));
	   	}
    }	

}
