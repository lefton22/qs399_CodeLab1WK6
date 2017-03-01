using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class c_shaow : MonoBehaviour {

	GameObject llll;
	GameObject meetwith1;
	GameObject meetwith2;
	public string name;
	public string nameMeet1;
	public string nameMeet2;

	Animator ani_sa1;

	private SpriteRenderer spriteR;
	private Sprite[] sprites;

	public string Spname1;
	public string ani_name1;
	public string ani_name2;
	public string ani_name3;

	bool isMeetwith1 = false;
	bool isMeetwith2 = false;


	public string fileName = "temp.txt";
	public List<string> events;
	string finalFilePath;


	void Start () 
	{
		llll = GameObject.Find (name);
		meetwith1 = GameObject.Find (nameMeet1);
		meetwith2 = GameObject.Find (nameMeet2);

		ani_sa1 = GetComponent<Animator>();
		print ("ani: " + ani_sa1);

		spriteR = gameObject.GetComponent<SpriteRenderer>();
		sprites = Resources.LoadAll<Sprite>(Spname1);


		Debug.Log("Path: " + Application.dataPath);
		finalFilePath = Application.dataPath + "/" + fileName;

	}
	

	void Update () 
	{
		transform.position = new Vector3(llll.transform.position.x, transform.position.y, transform.position.z) ;

		if (Mathf.Abs (transform.position.x - meetwith1.transform.position.x) < 0.1f  && !isMeetwith2) 
		{
			//print (gameObject + " meet " + meetwith1);
			ani_sa1.SetBool (ani_name1, true);
			Destroy (meetwith1);

			isMeetwith1 = true;
		}

//		if (Mathf.Abs (transform.position.x - meetwith1.transform.position.x) > 0.1f) 
//		{
//			print (gameObject + " meet " + meetwith1);
//			ani_sa1.SetBool (ani_name1, false);
//
//		}



		if (Mathf.Abs (transform.position.x - meetwith2.transform.position.x) < 0.1f && !isMeetwith1) 
		{
			//print (gameObject + " meet " + meetwith2);
			ani_sa1.SetBool (ani_name2, true);
			Destroy (meetwith2);

			isMeetwith2 = true;
		}


//		StreamWriter sw = new StreamWriter (finalFilePath, false);
//
//		for (int i = 0; i < 9; i++)
//		{
//			sw.WriteLine (name + " meets " + meetwith1);
//			//print (name + "meet" + meetwith1);
//		sw.Close ();
//		}


		StreamReader sr = new StreamReader (finalFilePath);

		//int j = 0;

		while (!sr.EndOfStream)
		{
			string line = sr.ReadLine ();

			string[] splitLIne = line.Split (' ');

			string name2 = splitLIne[0];
			string value2 = splitLIne[1];

			print ("name: " + name2);
			print ("value2: " + value2); 

			print (splitLIne);


			//j++;
		}

		sr.Close ();


	}
}
