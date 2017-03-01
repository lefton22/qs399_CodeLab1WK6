using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class scr_savegame : MonoBehaviour {
	
	string fileName ;

	string filePath;

	public static int levelNum = 0;

	const char DELIMITER = '|';

	public bool loadPlayer = false;

	GameObject lA;

	void Start () 
	{

		fileName = "temp.txt";

		filePath = Application.dataPath + "/" + fileName;

		lA = GameObject.Find ("A");

		if (File.Exists (filePath) && loadPlayer)
		{
			print ("txt exist");

			StreamReader sr = new StreamReader(filePath);

			string line = sr.ReadLine();

			sr.Close ();

			string[] splitLine = line.Split (DELIMITER);
	
		}			
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			print ("save!");

			Vector3 Apos = lA.transform.position;

			StreamWriter sw = new StreamWriter (filePath,false);

			sw.WriteLine("" +
				Apos.x + DELIMITER +
				Apos.y + DELIMITER +
				Apos.z + DELIMITER, fileName );

			sw.Close();
		}
	}
}
