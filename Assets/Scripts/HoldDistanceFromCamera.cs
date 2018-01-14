using UnityEngine;
using System.Collections;

public class HoldDistanceFromCamera : MonoBehaviour
{
	// Update is called once per frame
	void Update () 
	{
		if(Drag.ItemBeingDragged != null)
		{
			transform.localPosition = new Vector3(0.0f, 0.0f, 0.1f);
		}
	}
}
