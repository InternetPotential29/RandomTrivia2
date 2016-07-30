using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {
	
	public static GameObject objectBeingDragged;
	Vector3 sPosition;
	Transform destinationPosition;

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData) {
		objectBeingDragged = gameObject;
		sPosition = transform.position;
		destinationPosition = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData) {
		transform.position = Input.mousePosition;
		/*int nbTouches = Input.touchCount;

		if (nbTouches > 0) {
			for (int i = 0; i < nbTouches; i++) {
				Touch touch = Input.GetTouch (i);
				transform.position = touch.position;
			}
		}*/
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData) {
		objectBeingDragged = null;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		/*if (transform.parent == destinationPosition) {
			transform.position = sPosition;
		}*/
	}

	#endregion
}
