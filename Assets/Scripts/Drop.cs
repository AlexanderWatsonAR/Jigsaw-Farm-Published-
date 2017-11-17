using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Drop : MonoBehaviour , IDropHandler
{	
	public GameObject item
	{
		get
		{
			// If the slot has more than one child then return the first child.
			if (transform.childCount > 0)
				return transform.GetChild(0).gameObject;
			return null;
		}
	}

	#region IdropHandler implementation
	public void OnDrop(PointerEventData eventData)
	{
		if (!item)
			Drag.ItemBeingDragged.transform.SetParent(transform);
	}
	#endregion
	
}﻿