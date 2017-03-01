using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_move : MonoBehaviour {


	void Start ()
	{
		//transform.position = new Vector3 (-0.25f, -0.07f, 25.1f);
	}
	

	void Update () 
	{
		float x = transform.position.x;
		float z = transform.position.z;


		x += 0.01f;



		if (Input.GetKey (KeyCode.UpArrow)) 
		{			
			//print ("up");	
			x += 0.05f;
			transform.position = new Vector3 (x,0,transform.position.z);
		} 
		if (Input.GetKey (KeyCode.DownArrow)) 
		{			
			x -= 0.05f;
			transform.position = new Vector3 (x,0,transform.position.z);
		} 

		if (Input.GetKey (KeyCode.RightArrow)) 
		{			
			//print ("right");
			z -= 0.05f;
			transform.position = new Vector3 (transform.position.x,0,z);
		} 
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{			
			//print ("left");
			z += 0.05f;
			transform.position = new Vector3 (transform.position.x,0,z);
		} 


	}
}
