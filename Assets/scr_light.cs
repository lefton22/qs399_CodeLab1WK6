using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_light : MonoBehaviour {


	GameObject ldir1;
	// Use this for initialization
	void Start () {
		ldir1 = GameObject.Find ("dir0");
	}

	// Update is called once per frame
	void Update () {
//			transform.position = new Vector3 (transform.position.x + 0.02f, 
//				transform.position.y, transform.position.z );

		//transform.LookAt (ldir1.transform);
//		if (transform.position.x > 2.9f) 
//					{
//						transform.position = new Vector3 (-0.4f, transform.position.y, transform.position.z);
//					}
	}
}
