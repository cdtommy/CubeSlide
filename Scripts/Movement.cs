﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody rb;


	public float forwardForce = 50f;
	public float rightForce = 25f;
	public float leftForce = -25f;
	public float backForce = -50f;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		if(Input.GetKey("d") )
		{
			rb.AddForce(rightForce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
		}

		if(Input.GetKey("a") )
		{
			rb.AddForce(leftForce * Time.deltaTime , 0, 0, ForceMode.VelocityChange);
		}
		if(Input.GetKey("s") )
		{
			rb.AddForce(0, 0, backForce * Time.deltaTime, ForceMode.VelocityChange);
		}	

		if(Input.GetKey("w") )
		{
			rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
		}

		if(Input.GetKey("left ctrl") && Input.GetKey("w")) 		
		{
			rb.AddForce(0, 0, 100 * Time.deltaTime, ForceMode.VelocityChange);
		}

	
		if(rb.position.y < -1f)	
		{
			FindObjectOfType<GameManager>().EndGame();	
		}



		}	
	}


