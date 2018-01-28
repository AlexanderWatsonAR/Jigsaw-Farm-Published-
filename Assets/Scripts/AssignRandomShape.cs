using UnityEngine;

public class AssignRandomShape : MonoBehaviour 
{
	public GameObject Parent;
	public GameObject Piece;
	public Mesh[] Models;

	// Use this for initialization
	void Start () 
	{
		int index = Random.Range(0, Models.Length);
		Mesh model = Models[index];
		gameObject.GetComponent<MeshFilter>().sharedMesh = model;
		string tag = model.name;
		tag = tag.Remove(0, tag.LastIndexOf('_') + 1);
		gameObject.tag = tag;
		Parent.tag = tag;

		Piece.GetComponent<MeshFilter>().sharedMesh = model;
		Piece.GetComponent<MeshRenderer>().material = new Material(GameObject.FindGameObjectWithTag("Board").GetComponent<MeshRenderer>().material);
		Piece.tag = tag;
	}
}
