using UnityEngine;
using System.Collections;

public class AssignRandomMaterial : MonoBehaviour
{
	public Material[] Materials;

	// Use this for initialization
	void Awake()
	{
		int childIndex = 0;

		if(Materials.Length > 1)
			childIndex = Random.Range(0, Materials.Length);

		GetComponent<MeshRenderer>().material = new Material(Materials[childIndex]);
	}
}
