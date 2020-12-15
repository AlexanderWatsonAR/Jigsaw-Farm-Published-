using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject canvas;
	public static GameObject ItemBeingDragged;

	public Transform startParent;
	public Vector3 startPosition;
	Vector3 offsetToMouse;
	float zDistanceToCamera;

	#region Interface Implementations

    void Start()
    {
        startPosition = transform.position;
        startParent = transform.parent;
    }
	
	public void OnBeginDrag (PointerEventData eventData)
	{
		ItemBeingDragged = gameObject;
        Vector3 newPosition = transform.position;
		zDistanceToCamera = Mathf.Abs (startPosition.z - Camera.main.transform.position.z);
		offsetToMouse = newPosition - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistanceToCamera));
		if(GetComponent<CanvasGroup>() != null)
			GetComponent<CanvasGroup>().blocksRaycasts = false;

        if (ItemBeingDragged.transform.parent != null)
        {
            if (ItemBeingDragged.transform.parent.gameObject.GetComponent<CheckCorrectPiece>() != null)
                ItemBeingDragged.transform.parent.gameObject.GetComponent<CheckCorrectPiece>().IsCorrectPiece = false;
        }

    }
	
	public void OnDrag (PointerEventData eventData)
	{
		if(Input.touchCount > 1)
			return;
        transform.SetParent(canvas.transform, true);
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zDistanceToCamera - 0.1f)) + offsetToMouse;
	}
	
	public void OnEndDrag (PointerEventData eventData)
	{
		ItemBeingDragged = null;
		if(GetComponent<CanvasGroup>() != null)
			GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == canvas.transform)
        {
            transform.SetParent(startParent, true);
            transform.position = startPosition;
        }
	}
	
	#endregion
}