﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f,
	        moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
