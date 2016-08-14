using UnityEngine;
using System.Collections;

public class QuizController : MonoBehaviour {

	public GameObject SetC;
	public GameObject SetA;
	public GameObject SetB;

	public void transitionToSetC () {
		SetB.SetActive (false);
		SetA.SetActive (false);
		SetC.SetActive (true);
		GameObject.Find ("ImageQuestion").SetActive (false);
		Destroy (gameObject.GetComponent<MultipleChoiceQuiz> ());
	}
}
