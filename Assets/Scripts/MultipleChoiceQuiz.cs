using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MultipleChoiceQuiz : MonoBehaviour {

	public QuestionsSetA[] questionsSetA;
	private List<QuestionsSetA> unansweredQuestionsSetA;
	private QuestionsSetA currentQuestionSetA;

	public Image questionImage;
	private int currentQuestionIndex;

	public bool setA, setB;

	void Start () {
		unansweredQuestionsSetA = questionsSetA.ToList<QuestionsSetA> ();
		SetRandomQuestion ();
	}

	void SetRandomQuestion() {
		currentQuestionIndex = Random.Range (0, unansweredQuestionsSetA.Count);
		currentQuestionSetA = unansweredQuestionsSetA[currentQuestionIndex];
		questionImage.sprite = currentQuestionSetA.imageQuestionSetA;
		unansweredQuestionsSetA.RemoveAt (currentQuestionIndex);
	}

	public void CheckAnswer(int ans) {
		if(ans == currentQuestionSetA.answerSetA) {
			Debug.Log ("Correct!");
			//memo: place score code here
		} else {
			Debug.Log ("Wrong!");
		}

		CheckQuestionList ();
	}

	void CheckQuestionList (){
		if (unansweredQuestionsSetA.Count == 0 || unansweredQuestionsSetA == null) {
			Debug.Log ("Finish!");
			// SetB
		} else {
			SetRandomQuestion ();
		}
	}
}
