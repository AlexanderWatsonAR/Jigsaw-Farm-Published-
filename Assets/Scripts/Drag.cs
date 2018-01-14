using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public static GameObject ItemBeingDragged;

	public float ZPositionOnDrag;

	Transform startParent;
	Vector3 startPosition;
	Vector3 offsetToMouse;
	float zDistanceToCamera;

	#region Interface Implementations
	
	public void OnBeginDrag (PointerEventData eventData)
	{
		ItemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		zDistanceToCamera = Mathf.Abs (startPosition.z - Camera.main.transform.position.z);
		offsetToMouse = startPosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistanceToCamera));
		if(GetComponent<CanvasGroup>() != null)
			GetComponent<CanvasGroup>().blocksRaycasts = false;
	}
	
	public void OnDrag (PointerEventData eventData)
	{
		if(Input.touchCount > 1)
			return;

		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistanceToCamera)) + offsetToMouse;
		transform.position = new Vector3 (transform.position.x, transform.position.y, ZPositionOnDrag);
	}
	
	public void OnEndDrag (PointerEventData eventData)
	{
		ItemBeingDragged = null;
		if(GetComponent<CanvasGroup>() != null)
			GetComponent<CanvasGroup>().blocksRaycasts = true;
		if (transform.parent == startParent)
			transform.position = startPosition;
	}
	
	#endregion
}