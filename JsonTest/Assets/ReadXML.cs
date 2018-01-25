using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;


public class ReadXML : MonoBehaviour {
	public GameObject cube;


	int x=0;
	int z=0;

	// Use this for initialization
	void Start () 
	{
		XmlDocument xml = new XmlDocument ();
		xml.Load (XmlReader.Create("Assets/HousePos.xml"));
		XmlNodeList xmlPoses = xml.SelectSingleNode("Poses").ChildNodes;
		foreach (XmlElement xmlPos in xmlPoses) 
		{
			foreach (XmlElement xAndy in xmlPos) 
			{
				if (xAndy.Name == "xpos") 
				{
					x = int.Parse(xAndy.InnerText);
					Debug.Log (x);
				}
				if (xAndy.Name == "ypos") 
				{
					z = int.Parse(xAndy.InnerText);
					Debug.Log (z);
				}
			}
			Vector3 position = new Vector3 (x, 0, z);
			Instantiate (cube, position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
