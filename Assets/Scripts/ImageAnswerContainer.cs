using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ImageAnswerContainer : MonoBehaviour, IDropHandler {

	private DragDropQuizUnit1 dragQuiz;

	public GameObject item {
		get {
			if (transform.childCount > 0) {
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		if (!item) {
			DragHandler.objectBeingDragged.transform.SetParent (transform);
			dragQuiz = GameObject.Find("SetC").GetComponent <DragDropQuizUnit1> ();
			dragQuiz.checkImageAnswer (item);
		}
	}

	#endregion
}
