using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float rotationAmount = 0.5f;
    void Update()
    {
       if(Input.GetButton("TurnLeft")){
		   Debug.Log("TurnLeft");
		   transform.Rotate(new Vector3(0, -rotationAmount, 0));
	   }

	   if(Input.GetButton("TurnRight")){
		   Debug.Log("TurnRight");
		   transform.Rotate(new Vector3(0, rotationAmount, 0));
	   }
    }
	
}
