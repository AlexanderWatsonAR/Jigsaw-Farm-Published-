using UnityEngine;
using System.Collections;

public class ChildLayout : MonoBehaviour
{
	private Transform child;
	private Transform grandChild;
	private int startChildCount;
	private int previousChildCount;

	void Start()
	{
		startChildCount = transform.childCount;
		previousChildCount = startChildCount;
	}

	// Update is called once per frame
	// When new children are added added their local position is centered.
	void Update () 
	{
		Debug.Log(name);
		Debug.Log(transform.childCount);
		if (transform.childCount <= startChildCount)
			return;

		if (previousChildCount == transform.childCount)
			return;

		previousChildCount = transform.childCount;
		child = transform.GetChild(transform.childCount - 1);
		grandChild = child.GetChild (child.childCount - 1);

		if (Drag.ItemBeingDragged == null)
		{
			child.localPosition = new Vector3 ();
			if (grandChild != null)
				grandChild.localPosition = new Vector3 ();
		} 
	}
}
