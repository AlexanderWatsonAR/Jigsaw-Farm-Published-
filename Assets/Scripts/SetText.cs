using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetText : MonoBehaviour {

	// Use this for initialization
	void Start() 
	{
		GameObject jigsawPieces = GameObject.FindGameObjectWithTag("JigsawPieces");
		CreateJigawPieces script = jigsawPieces.GetComponent<CreateJigawPieces>();
		GetComponent<Text>().text = script.Cartoon.name;
	}
}
