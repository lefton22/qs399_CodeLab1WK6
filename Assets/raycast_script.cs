using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast_script : MonoBehaviour {

	GameObject beSliced;
	Vector3 v3_beSliced;
	GameObject beSliced2;
	Vector3 v3_beSliced2;

	GameObject ldir1;
	GameObject ldir2;

	GameObject la_point;
	GameObject lb_point;

	public Material capMaterial;

	int yourchance;


	// Use this for initialization
	void Start () {
		ldir1 = GameObject.Find ("dir1");
		ldir2 = GameObject.Find ("dir2");

		la_point = GameObject.Find ("a_point");
		lb_point = GameObject.Find ("b_point");

		//Debug.Log (ldir1.transform.position);

		yourchance = 3;
	}
	

		void Update () 
	{
			RaycastHit hit;
			float theDistance;
			Vector3 hitPointWorld;

			//Vector3 forward = transform.TransformDirection (Vector3.forward) * 10;
	//		Debug.DrawLine (transform.position,lb_point.transform.position/*forward*/,Color.green);
	//		Debug.DrawLine (transform.position,la_point.transform.position/*forward*/,Color.green);

			Debug.DrawRay (transform.position,ldir1.transform.position,Color.green);
			Debug.DrawRay (transform.position,ldir2.transform.position,Color.green);

	//		if (Physics.Raycast (transform.position, ldir1.transform.position/*(forward)*/, out hit, 100f)) 
	//		{
	//			print ("yes");
	//		}

	// Raycast towards dir1 and detect the collision with Cube2; 
		
			if (Physics.Raycast (transform.position, ldir1.transform.position/*(forward)*/, out hit, 1000f)) 
			{
	
				RaycastHit[] hits2;
				hits2 = Physics.RaycastAll(transform.position, ldir1.transform.position, 1000.0F);
				//print ("yes a");


         // cut according to shadow strictly


			if (hits2[1].collider.gameObject.name == "Cube2" || hits2[1].collider.gameObject.name == "left side"|| hits2[1].collider.gameObject.name == "Cube4")  // if colliding with Cube2, draw a line.
						{

							print ("2nd line");
							beSliced2 = hits2 [1].collider.gameObject;
							v3_beSliced2 =hits2[1].point;
							//print ("v3_beSliced: " +v3_beSliced);
							//print ("beSliced gameobject: " + hits2 [1].collider.gameObject);

							Vector3 v3_beSlicedLoacl2 = hits2 [1].transform.InverseTransformPoint(transform.position);
							//print ("local v3: "+ v3_beSlicedLoacl2.x);

							Vector3 x2 = new Vector3 (v3_beSliced2.x, v3_beSliced2.y,v3_beSliced2.z);
							Vector3 y2= new Vector3 (v3_beSliced2.x, 15f,v3_beSliced2.x);

							Debug.DrawRay (x2, y2, Color.blue );

										if (Input.GetMouseButtonDown (0)) 
										{
											GameObject victim = hits2[1].collider.gameObject;
						                    GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut (victim, ldir1.transform.position, transform.right, capMaterial);
											if (!pieces [1].GetComponent<Rigidbody> ())
												pieces [1].AddComponent<Rigidbody> ();
					
											Destroy (pieces [1], 1);
											print ("cut according to shadow" );
										}	
				

					    }

				}




		if (Physics.Raycast (transform.position,ldir2.transform.position, out hit, 1000f)) 

		{

			print ("yes b");

			theDistance = hit.distance;
			hitPointWorld = hit.point;
			//print (theDistance + " " + hit.collider.gameObject);
			//print ("hitPointWorld:" + " " + hitPointWorld);

			RaycastHit[] hits;
			hits = Physics.RaycastAll(transform.position, ldir2.transform.position, 1000.0F);

			//				print ("cast all: "+ hits[0].collider.gameObject +" " + hits[1].collider.gameObject);
			//
			//				print ("first collider's point: " + hits [0].point);

			//if (hit.collider.gameObject.name == "a_point") 
			if (hits[1].collider.gameObject.name == "Cube2" )
			{
				//print ("collider a_point!");
				//此时，求出此条射线与cube2相交的点

				beSliced = hits [1].collider.gameObject;
				v3_beSliced =hits[1].point;
				//print ("v3_beSliced: " +v3_beSliced);
				print ("beSliced gameobject: " + hits [1].collider.gameObject);



				//转换成cube的本地坐标

				Vector3 v3_beSlicedLoacl = hits [1].transform.InverseTransformPoint(transform.position);
				print ("local v3: "+ v3_beSlicedLoacl.x);

				Vector3 x = new Vector3 (v3_beSliced.x, v3_beSliced.y,v3_beSliced.z);
				Vector3 y = new Vector3 (v3_beSliced.x, 15f,v3_beSliced.x);

				//Vector3 x = new Vector3 (v3_beSlicedLoacl.transform.TransformPoint.x, 0,0);

				Debug.DrawRay (x, y, Color.red );

			}

		}
























	// Raycast towards dir1 and detect the collision with Cube3; 
//
//			if (Physics.Raycast (transform.position, ldir1.transform.position/*(forward)*/, out hit, 1000f)) 
//			{
//
//				RaycastHit[] hits2;
//				hits2 = Physics.RaycastAll(transform.position, ldir1.transform.position, 1000.0F);
//				//print ("yes a");
//
//				if (hits2[1].collider.gameObject.name == "Cube3" )
//				{
//
//					print ("2nd line");
//					beSliced2 = hits2 [1].collider.gameObject;
//					v3_beSliced2 =hits2[1].point;
//					//print ("v3_beSliced: " +v3_beSliced);
//					//print ("beSliced gameobject: " + hits2 [1].collider.gameObject);
//
//					Vector3 v3_beSlicedLoacl2 = hits2 [1].transform.InverseTransformPoint(transform.position);
//					//print ("local v3: "+ v3_beSlicedLoacl2.x);
//
//					Vector3 x2 = new Vector3 (v3_beSliced2.x, v3_beSliced2.y,v3_beSliced2.z);
//					Vector3 y2= new Vector3 (v3_beSliced2.x, 15f,v3_beSliced2.x);
//
//					Debug.DrawRay (x2, y2, Color.yellow );
//
//				}
//
//			}


	// Raycast towards dir2 and detect the collision with Cube2;


	//// Raycast towards dir2 and detect the collision with Cube3;
	//
	//
	//		if (Physics.Raycast (transform.position,ldir2.transform.position/*(forward)*/, out hit, 1000f)) 
	//		{
	//
	//			//print ("yes b");
	//
	//			theDistance = hit.distance;
	//			hitPointWorld = hit.point;
	//			//print (theDistance + " " + hit.collider.gameObject);
	//			//print ("hitPointWorld:" + " " + hitPointWorld);
	//
	//			RaycastHit[] hits;
	//			hits = Physics.RaycastAll(transform.position, ldir2.transform.position, 1000.0F);
	//
	//			print ("cast all: "+ hits[0].collider.gameObject +" " + hits[1].collider.gameObject);
	//
	//			print ("first collider's point: " + hits [0].point);
	//
	//			//if (hit.collider.gameObject.name == "a_point") 
	//			if (hits[1].collider.gameObject.name == "Cube3" )
	//			{
	//				//print ("collider a_point!");
	//				//此时，求出此条射线与cube2相交的点
	//
	//				beSliced = hits [1].collider.gameObject;
	//				v3_beSliced =hits[1].point;
	//				//print ("v3_beSliced: " +v3_beSliced);
	//				print ("beSliced gameobject: " + hits [1].collider.gameObject);
	//
	//
	//
	//				//转换成cube的本地坐标
	//
	//				Vector3 v3_beSlicedLoacl = hits [1].transform.InverseTransformPoint(transform.position);
	//				print ("local v3: "+ v3_beSlicedLoacl.x);
	//
	//				Vector3 x = new Vector3 (v3_beSliced.x, v3_beSliced.y,v3_beSliced.z);
	//				Vector3 y = new Vector3 (v3_beSliced.x, 15f,v3_beSliced.x);
	//
	//				//Vector3 x = new Vector3 (v3_beSlicedLoacl.transform.TransformPoint.x, 0,0);
	//
	//				Debug.DrawRay (x, y, Color.yellow );
	//
	//			}
	//
	//		}


	//				if (Physics.Raycast (transform.position,ldir1.transform.position/*(forward)*/, out hit, 1000f)) 
	//				{
	//		
	//					//print ("yes b");
	//		
	//					theDistance = hit.distance;
	//					hitPointWorld = hit.point;
	//					//print (theDistance + " " + hit.collider.gameObject);
	//					//print ("hitPointWorld:" + " " + hitPointWorld);
	//		
	//					RaycastHit[] hits;
	//					hits = Physics.RaycastAll(transform.position, ldir1.transform.position, 1000.0F);
	//		
	//					print ("cast all: "+ hits[0].collider.gameObject +" " + hits[1].collider.gameObject);
	//		
	//					print ("first collider's point: " + hits [0].point);
	//		
	//					//if (hit.collider.gameObject.name == "a_point") 
	//					if (hits[1].collider.gameObject.name == "Cube2" )
	//					{
	//						//print ("collider a_point!");
	//						//此时，求出此条射线与cube2相交的点
	//		
	//						beSliced = hits [1].collider.gameObject;
	//						v3_beSliced =hits[1].point;
	//						//print ("v3_beSliced: " +v3_beSliced);
	//						print ("beSliced gameobject: " + hits [1].collider.gameObject);
	//		
	//		
	//		
	//						//转换成cube的本地坐标
	//		
	//						Vector3 v3_beSlicedLoacl = hits [1].transform.InverseTransformPoint(transform.position);
	//						print ("local v3: "+ v3_beSlicedLoacl.x);
	//		
	//						Vector3 x = new Vector3 (v3_beSliced.x, v3_beSliced.y,v3_beSliced.z);
	//						Vector3 y = new Vector3 (v3_beSliced.x, 15f,v3_beSliced.x);
	//						 
	//						//Vector3 x = new Vector3 (v3_beSlicedLoacl.transform.TransformPoint.x, 0,0);
	//		
	//						Debug.DrawRay (x, y, Color.red );
	//		
	//					}
	//		
	//		//			slice , then delete one side
	//		//			do mask
	//				}






		}
}
