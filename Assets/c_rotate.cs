using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_rotate : MonoBehaviour {

	public float Rspeed;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * Rspeed );	
	}
}
