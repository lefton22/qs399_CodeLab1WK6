using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_controlrotate : MonoBehaviour {
	public float rspeed;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButton (1)) 
		{
			transform.Rotate( 0, rspeed, 0);
		}
	}
}
