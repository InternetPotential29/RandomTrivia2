using UnityEngine;
using System.Collections;

public class ScalingOnLayout : MonoBehaviour {

	void Start () {
		this.GetComponent<RectTransform> ().localScale = Vector3.one;
	}

}
