using UnityEngine;

public class AssignRandomShape : MonoBehaviour 
{
	public GameObject Parent;
	public GameObject Piece;
    public GameObject Board;
	public Mesh[] Models;

	// Use this for initialization
	void Start () 
	{
		int index = Random.Range(0, Models.Length);
		Mesh model = Models[index];
		gameObject.GetComponent<MeshFilter>().sharedMesh = model;
		gameObject.tag = tag;
		Parent.tag = tag;

		Piece.GetComponent<MeshFilter>().sharedMesh = model;
		Piece.GetComponent<MeshRenderer>().material = new Material(Board.GetComponent<MeshRenderer>().material);
		Piece.tag = tag;
	}
}
