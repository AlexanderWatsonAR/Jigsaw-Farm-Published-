using UnityEngine;
using System.Collections;

public class ChildLayout : MonoBehaviour
{
	// Update is called once per frame
	void Update () 
	{
		if (transform.childCount <= 0)
			return;
		transform.GetChild(0).transform.localPosition = new Vector3();
	}
}
