using UnityEngine;
using System.Collections;

public class GenerateRandomModel : MonoBehaviour 
{
	public GameObject Parent;
	public GameObject Piece;
	public Mesh[] Models;

	// Use this for initialization
	void Start () 
	{
		int index = Random.Range(0, Models.Length - 1);
		Mesh model = Models[index];
		gameObject.GetComponent<MeshFilter>().sharedMesh = model;
		string tag = model.name;
		tag = tag.Remove(0, tag.LastIndexOf('_') + 1);
		gameObject.tag = tag;
		Parent.tag = tag;

		Piece.GetComponent<MeshFilter>().sharedMesh = model;
		Piece.GetComponent<MeshRenderer>().material = new Material(GameObject.FindGameObjectWithTag("Board").GetComponent<MeshRenderer>().material);
//		int sortNumber = int.Parse(Piece.name.Remove(0, Piece.name.LastIndexOf(' ') + 1));
//		Piece.GetComponent<MeshRenderer>().sortingOrder = sortNumber;
		Piece.tag = tag;
	}
}
