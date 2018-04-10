using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float rotationAmount = 0.5f;
	public float distanceAmount = 0.5f;
	[SerializeField] float maxDistance = 4f;
	[SerializeField] float minDistance = 1f;
	[SerializeField] GameObject red;
	[SerializeField] GameObject blue; 
   
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

/*	   if(Input.GetButton("DistanceIncrease") && red.transform.position.x <= maxDistance/2){
		   Debug.Log("Distance Decrese");
		   red.transform.position = new Vector3(red.transform.position.x + distanceAmount/2, 0, 0);	   
	   	   blue.transform.position = new Vector3(blue.transform.position.x - distanceAmount/2, 0, 0);
	   }

	   if(Input.GetButton("DistanceDecrease") && red.transform.position.x >= minDistance/2){
		   Debug.Log("DistanceDecrease");
		   red.transform.position = new Vector3(red.transform.position.x - distanceAmount/2, 0, 0);	   
	   	   blue.transform.position = new Vector3(blue.transform.position.x + distanceAmount/2, 0, 0);
	   }
*/
    }	
}
