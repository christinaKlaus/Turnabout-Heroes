using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public enum Directions{
		None, 
		Left,
		Right
	}
	public PlayerController playerController;
	public Directions direction;

	
    public void OnPointerDown(PointerEventData eventData)
    {
        playerController.currentDirection = direction;
    }

	public void OnPointerUp(PointerEventData eventData){
		playerController.currentDirection = Directions.None;
	}


}
