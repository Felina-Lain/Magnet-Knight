﻿using UnityEngine;
using System.Collections;

public class dragverti : MonoBehaviour 
{
	
	private Vector3 screenPoint;
	private Vector3 offset;
	public bool IsDragable = true;
	public float posy = 0f;
	
	void OnMouseDown()
	{
		if(IsDragable)    // Only do if IsDraggable == true
		{
			screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
			
			offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, posy, screenPoint.z));
		}
	}
	
	void OnMouseDrag()
	{
		if(IsDragable)    // Only do if IsDraggable == true
		{
			Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, posy, screenPoint.z); // hardcode the y and z for your use
			
			Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
			transform.position = curPosition;
		}
	}
	
}