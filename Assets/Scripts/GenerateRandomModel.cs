using UnityEngine;
using System.Collections;

public class GenerateRandomModel : MonoBehaviour 
{
	public GameObject piece;
	public Mesh[] models;
	public Material[] materials;
	public Material background;

	// Use this for initialization
	void Start () 
	{
		gameObject.AddComponent<MeshFilter>();
		gameObject.AddComponent<MeshRenderer>();
		MeshFilter slotMeshFilter = GetComponent<MeshFilter>();
		int index = (int)Random.Range(0.0f, (float)models.Length);
		slotMeshFilter.mesh = models[index];
		string tag = slotMeshFilter.mesh.name;
		tag = tag.Remove (0, tag.LastIndexOf ('_') + 1);
		tag = tag.Remove (tag.LastIndexOf(' '));
		gameObject.tag = tag;
		gameObject.GetComponent<MeshRenderer>().material = new Material(background);

		piece.AddComponent<MeshFilter>();
		piece.AddComponent<MeshRenderer>();
		MeshFilter pieceMeshFilter = piece.GetComponent<MeshFilter>();
		pieceMeshFilter.mesh = slotMeshFilter.mesh;
		piece.tag = tag;
		piece.GetComponent<MeshRenderer>().material = new Material(materials[0]);
	}
}
