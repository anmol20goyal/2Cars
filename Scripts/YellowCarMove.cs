﻿using System;
using UnityEngine;

public class YellowCarMove : MonoBehaviour
{
	private Vector3 position;
	private int laneNum = 2;
    
	// Start is called before the first frame update
	void Start()
	{
		position = transform.position;
	}
	
	public void RightBtn()
	{
		if (laneNum == 1)
		{
			// move left
			position.x = transform.position.x - 0.23f;
			transform.position = position;
			laneNum = 2;
		}
		else if (laneNum == 2)
		{
			// move right
			position.x = transform.position.x + 0.23f;
			transform.position = position;
			laneNum = 1;
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			if (laneNum == 1)
			{
				// move left
				position.x = transform.position.x - 0.23f;
				transform.position = position;
				laneNum = 2;
			}
			else if (laneNum == 2)
			{
				// move right
				position.x = transform.position.x + 0.23f;
				transform.position = position;
				laneNum = 1;
			}
		}
	}
}
