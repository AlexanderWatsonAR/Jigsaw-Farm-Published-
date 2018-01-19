using UnityEngine;
using System.Collections;

public class ChildLayout : MonoBehaviour
{
	private Transform child;
	private int startChildCount;
	private int previousChildCount;


	void Start()
	{
		startChildCount = transform.childCount;
	}

	// Update is called once per frame
	// When new children are added added their local position is centered.
	void Update () 
	{
		if (transform.childCount <= startChildCount)
			return;

		if (GetComponent<Drop>().AtMaxChildNumber)
			return;

		child = transform.GetChild(transform.childCount - 1);
		
		if (Drag.ItemBeingDragged == null)
			child.localPosition = new Vector3(); 
	}
}
