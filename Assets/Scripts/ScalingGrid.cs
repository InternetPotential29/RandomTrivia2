using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScalingGrid : MonoBehaviour {

	void Start () {
		RectTransform parent = gameObject.GetComponent<RectTransform> ();
		GridLayoutGroup grid = gameObject.GetComponent<GridLayoutGroup> ();

		grid.cellSize = new Vector2 (parent.rect.width / 2, parent.rect.height / 2);
	}
}
