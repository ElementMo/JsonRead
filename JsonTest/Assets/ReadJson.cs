using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class ReadJson : MonoBehaviour {
	public TextAsset jsonData;
	public GameObject cube;

	void Start () {
		JsonObjectModel jo = JsonMapper.ToObject<JsonObjectModel> (jsonData.text);
		foreach (var pos in jo.infoList) 
		{
			Vector3 position = new Vector3 (pos.xpos, 0, pos.ypos);
			Instantiate (cube, position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class JsonObjectModel 
{
	public List<JsonArrayModel> infoList;

}

public class JsonArrayModel
{
	public float xpos;
	public float ypos;
}